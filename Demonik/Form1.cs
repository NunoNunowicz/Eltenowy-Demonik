using Chilkat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
namespace Demonik
{
	public partial class WND_Login : Form
	{
		public WND_Login()
		{
			InitializeComponent();
		}
		SpeechSynthesizer TTS = new SpeechSynthesizer();
		private void WND_Login_Load(object sender, EventArgs e)
		{
		}
		private void TXT_Login_Enter(object sender, EventArgs e)
		{
			TTS.SpeakAsync("Login");
		}
		private void TXT_Password_Enter(object sender, EventArgs e)
		{
			TTS.SpeakAsync("Hasło");
		}

		private void BTN_Login_Enter(object sender, EventArgs e)
		{
			TTS.SpeakAsync("Zaloguj się");
		}

		private void BTN_Login_Click(object sender, EventArgs e)
		{
			
			this.Hide();
			var MainWindow = new WND_Main();
			MainWindow.Login = TXT_Login.Text;
			MainWindow.Password = TXT_Password.Text;
			MainWindow.Closed += (s, args) => this.Close();
			MainWindow.Show();
		}
	}
	}