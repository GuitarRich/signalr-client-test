namespace Lightmaker.SignalR.HubTest.SignalR
{
	using System;

	using Microsoft.AspNet.SignalR.Client;

	public class SignalRClient
	{
		protected readonly string SignalRUrl;
		protected readonly string SignalRHub;

		protected bool IsConnected;
		protected HubConnection Connection;

		public SignalRClient(string url, string hub)
		{
			this.SignalRUrl = url;
			this.SignalRHub = hub;
		}

		public async void Connect(Action<dynamic> receiveAction, string onMethod)
		{
			this.Connection = new HubConnection(this.SignalRUrl);
			var hubProxy = this.Connection.CreateHubProxy(this.SignalRHub);
			hubProxy.On(onMethod, receiveAction);
			await this.Connection.Start();
		}
	}
}
