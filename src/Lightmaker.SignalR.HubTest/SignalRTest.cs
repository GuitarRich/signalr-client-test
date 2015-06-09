using System;
using System.Windows.Forms;

namespace Lightmaker.SignalR.HubTest
{
	using System.Globalization;

	using SignalR;

	public partial class SignalRTest : Form
	{
		private int messagesReceived = 0;
		private long bytesRecieved = 0;

		public SignalRTest()
		{
			InitializeComponent();
		}

		private void startTest_Click(object sender, EventArgs e)
		{
			var max = int.Parse(maxConnections.Text);
			var total = 0;

			for (var x = 1; x <= max; x++)
			{
				total++;
				var hubNumber = x;
				var hub = new SignalRClient(signalRUrl.Text, signalRHub.Text);
				hub.Connect((data) => this.Invoke((MethodInvoker)delegate
				{
					this.messagesReceived++;
					var currentBytes = data.ToString().Length;
					this.bytesRecieved += currentBytes;
					this.results.Text = string.Format(
						"Messages Received: {0}\r\nTotal Bytes Received: {1}\r\nLast Bytes Received: {4}\r\nLast received on connection: {2}\r\n\r\nLast Message:\n\r{3}",
						messagesReceived,
						bytesRecieved,
						hubNumber,
						data,
						currentBytes);
					this.results.Update();
				}), onMethodName.Text);

				totalConnections.Text = total.ToString(CultureInfo.InvariantCulture);
				totalConnections.Update();
			}
		}

		private void SignalRTest_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
	}
}
