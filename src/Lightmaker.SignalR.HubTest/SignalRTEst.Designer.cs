namespace Lightmaker.SignalR.HubTest
{
	partial class SignalRTest
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.startTest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.results = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.totalConnections = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.onMethodName = new System.Windows.Forms.TextBox();
			this.maxConnections = new System.Windows.Forms.TextBox();
			this.signalRHub = new System.Windows.Forms.TextBox();
			this.signalRUrl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// startTest
			// 
			this.startTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startTest.Location = new System.Drawing.Point(908, 4);
			this.startTest.Margin = new System.Windows.Forms.Padding(2);
			this.startTest.Name = "startTest";
			this.startTest.Size = new System.Drawing.Size(164, 38);
			this.startTest.TabIndex = 5;
			this.startTest.Text = "Start Test";
			this.startTest.UseVisualStyleBackColor = true;
			this.startTest.Click += new System.EventHandler(this.startTest_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "SignalR Url";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 30);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "SignalR Hub";
			// 
			// results
			// 
			this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.results.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.results.Location = new System.Drawing.Point(11, 129);
			this.results.Margin = new System.Windows.Forms.Padding(2);
			this.results.Multiline = true;
			this.results.Name = "results";
			this.results.ReadOnly = true;
			this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.results.Size = new System.Drawing.Size(1061, 459);
			this.results.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 86);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Max Connections";
			// 
			// totalConnections
			// 
			this.totalConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.totalConnections.Location = new System.Drawing.Point(122, 105);
			this.totalConnections.Margin = new System.Windows.Forms.Padding(2);
			this.totalConnections.Name = "totalConnections";
			this.totalConnections.ReadOnly = true;
			this.totalConnections.Size = new System.Drawing.Size(711, 20);
			this.totalConnections.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 107);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total Connections";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 54);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "SignalR \"On\" Method";
			// 
			// onMethodName
			// 
			this.onMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.onMethodName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Lightmaker.SignalR.HubTest.Properties.Settings.Default, "signalROn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.onMethodName.Location = new System.Drawing.Point(122, 52);
			this.onMethodName.Margin = new System.Windows.Forms.Padding(2);
			this.onMethodName.Name = "onMethodName";
			this.onMethodName.Size = new System.Drawing.Size(711, 20);
			this.onMethodName.TabIndex = 2;
			this.onMethodName.Text = global::Lightmaker.SignalR.HubTest.Properties.Settings.Default.signalROn;
			// 
			// maxConnections
			// 
			this.maxConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.maxConnections.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Lightmaker.SignalR.HubTest.Properties.Settings.Default, "maxConnections", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.maxConnections.Location = new System.Drawing.Point(122, 84);
			this.maxConnections.Margin = new System.Windows.Forms.Padding(2);
			this.maxConnections.Name = "maxConnections";
			this.maxConnections.Size = new System.Drawing.Size(711, 20);
			this.maxConnections.TabIndex = 3;
			this.maxConnections.Text = global::Lightmaker.SignalR.HubTest.Properties.Settings.Default.maxConnections;
			// 
			// signalRHub
			// 
			this.signalRHub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.signalRHub.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Lightmaker.SignalR.HubTest.Properties.Settings.Default, "signalRHub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.signalRHub.Location = new System.Drawing.Point(122, 28);
			this.signalRHub.Margin = new System.Windows.Forms.Padding(2);
			this.signalRHub.Name = "signalRHub";
			this.signalRHub.Size = new System.Drawing.Size(711, 20);
			this.signalRHub.TabIndex = 1;
			this.signalRHub.Text = global::Lightmaker.SignalR.HubTest.Properties.Settings.Default.signalRHub;
			// 
			// signalRUrl
			// 
			this.signalRUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.signalRUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Lightmaker.SignalR.HubTest.Properties.Settings.Default, "signalRUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.signalRUrl.Location = new System.Drawing.Point(122, 4);
			this.signalRUrl.Margin = new System.Windows.Forms.Padding(2);
			this.signalRUrl.Name = "signalRUrl";
			this.signalRUrl.Size = new System.Drawing.Size(711, 20);
			this.signalRUrl.TabIndex = 0;
			this.signalRUrl.Text = global::Lightmaker.SignalR.HubTest.Properties.Settings.Default.signalRUrl;
			// 
			// SignalRTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 599);
			this.Controls.Add(this.onMethodName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.totalConnections);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.maxConnections);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.results);
			this.Controls.Add(this.signalRHub);
			this.Controls.Add(this.signalRUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.startTest);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "SignalRTest";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignalRTest_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startTest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox signalRUrl;
		private System.Windows.Forms.TextBox signalRHub;
		private System.Windows.Forms.TextBox results;
		private System.Windows.Forms.TextBox maxConnections;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox totalConnections;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox onMethodName;
		private System.Windows.Forms.Label label5;
	}
}

