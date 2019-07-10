namespace Demonik
{
	partial class WND_Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WND_Main));
			this.TM_Timer = new System.Windows.Forms.Timer(this.components);
			this.NTF_Notification = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// TM_Timer
			// 
			this.TM_Timer.Interval = 1000;
			this.TM_Timer.Tick += new System.EventHandler(this.TM_Timer_Tick);
			// 
			// NTF_Notification
			// 
			this.NTF_Notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.NTF_Notification.BalloonTipText = "Demonik";
			this.NTF_Notification.Icon = ((System.Drawing.Icon)(resources.GetObject("NTF_Notification.Icon")));
			this.NTF_Notification.Text = "Demonik!";
			this.NTF_Notification.Visible = true;
			this.NTF_Notification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NTF_Notification_MouseDoubleClick);
			// 
			// WND_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "WND_Main";
			this.Text = "Demonik";
			this.Load += new System.EventHandler(this.WND_Main_Load);
			this.Resize += new System.EventHandler(this.WND_Main_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer TM_Timer;
		private System.Windows.Forms.NotifyIcon NTF_Notification;
	}
}