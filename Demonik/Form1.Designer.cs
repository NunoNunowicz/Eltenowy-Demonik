namespace Demonik
{
	partial class WND_Login
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
			this.TXT_Login = new System.Windows.Forms.TextBox();
			this.TXT_Password = new System.Windows.Forms.TextBox();
			this.BTN_Login = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TXT_Login
			// 
			this.TXT_Login.AccessibleName = "Login";
			this.TXT_Login.Location = new System.Drawing.Point(0, 0);
			this.TXT_Login.Name = "TXT_Login";
			this.TXT_Login.Size = new System.Drawing.Size(100, 22);
			this.TXT_Login.TabIndex = 0;
			this.TXT_Login.Enter += new System.EventHandler(this.TXT_Login_Enter);
			// 
			// TXT_Password
			// 
			this.TXT_Password.AccessibleName = "Hasło";
			this.TXT_Password.Location = new System.Drawing.Point(8, 8);
			this.TXT_Password.Name = "TXT_Password";
			this.TXT_Password.PasswordChar = '*';
			this.TXT_Password.Size = new System.Drawing.Size(100, 22);
			this.TXT_Password.TabIndex = 1;
			this.TXT_Password.Enter += new System.EventHandler(this.TXT_Password_Enter);
			// 
			// BTN_Login
			// 
			this.BTN_Login.Location = new System.Drawing.Point(0, 0);
			this.BTN_Login.Name = "BTN_Login";
			this.BTN_Login.Size = new System.Drawing.Size(75, 23);
			this.BTN_Login.TabIndex = 2;
			this.BTN_Login.Text = "Zaloguj się";
			this.BTN_Login.UseVisualStyleBackColor = true;
			this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
			this.BTN_Login.Enter += new System.EventHandler(this.BTN_Login_Enter);
			// 
			// WND_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BTN_Login);
			this.Controls.Add(this.TXT_Password);
			this.Controls.Add(this.TXT_Login);
			this.Name = "WND_Login";
			this.Text = "Logowanie";
			this.Load += new System.EventHandler(this.WND_Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BTN_Login;
		public System.Windows.Forms.TextBox TXT_Login;
		public System.Windows.Forms.TextBox TXT_Password;
	}
}

