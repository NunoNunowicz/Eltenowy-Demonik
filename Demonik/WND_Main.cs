using Chilkat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonik
{
	public partial class WND_Main : Form
	{
public 		SpeechSynthesizer TTS = new SpeechSynthesizer();
		public WebClient NetClient = new WebClient();
		public Chilkat.JsonObject JsonClient = new Chilkat.JsonObject();
		public string Login = String.Empty;
		public String Password = String.Empty;
public 		string LoginInfo = String.Empty;
		public string token = String.Empty;
		public int FuckingCode;
		public int CurrentNumOfMessages = 0;
		public int ServerNumOfMessages;
		public int MessagesGotFromStartOfSession = 0;
		public WND_Main()
		{
			InitializeComponent();
		}
		private void WND_Main_Load(object sender, EventArgs e)
		{
			JsonClient.EmitCompact = false;
			try
			{
				LoginInfo = NetClient.DownloadString("https://api.elten-net.eu/login?name=" + Login + "&pass=" + Password + "");
			}
			catch
			{
				MessageBox.Show("A chuja tam.\nZłe dane zawsze oznaczają kłopoty","Kurwa mać!");
				this.Close();
				return;
			}
				bool Success = JsonClient.Load(LoginInfo);
			if (!Success)
			{
				MessageBox.Show("Coś się kurwa spierdoliło po całości. To, co jest w tej odpowiedzi to nie jest żaden, pierdolony jSon. Z polskiego na nasze: 1. Nie masz internetu. 2. Ten chujowy Elten się zjebał. 3. Nie umiem programować", "Chuj");
				return;
			}
			FuckingCode = JsonClient.IntOf("code");
			if (FuckingCode != 200)
			{
				MessageBox.Show("Rozumiem, że Elten jest chuja warty, ale żeby kurwa nie pamiętać hasła. Tu jest ten pierdolony błąd "+FuckingCode+","+LoginInfo+"", "Chuj");
			}
			token = JsonClient.StringOf("token");
			TTS.SpeakAsync("Zalogowano jako: " + JsonClient.StringOf("name"));
			TM_Timer.Start();
		}
		private void TM_Timer_Tick(object sender, EventArgs e)
		{
			JsonClient.Load(NetClient.DownloadString("https://api.elten-net.eu/messages/maxid?name=" + Login + "&token=" + token + "&cat=users"));
			this.Text = "Demonik: zalogowano jako" + Login + ", i otrzymano " + MessagesGotFromStartOfSession + " wiadomości od rozpoczęcia sesji z demonikiem";
			ServerNumOfMessages = JsonClient.IntOf("maxid");
			if (ServerNumOfMessages == CurrentNumOfMessages)
			{
				return;
			}
			else
			{
				TTS.Speak("Nowa wiadomość otrzymana.");
				CurrentNumOfMessages = ServerNumOfMessages;
			}
		}

		private void WND_Main_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				NTF_Notification.Visible = true;
			}
		}

		private void NTF_Notification_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			NTF_Notification.Visible = false;
		}
	}
}
