using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace PlayerUI
{
	public partial class Form1 : Form
	{
		Video v;
		public string mode = "play";
		public string PlayingPosition, Duration;
		public Form1()
		{


			InitializeComponent();
			VolumeTrackbar.Value = 4;
			//Menu Design code
			customizeDesign();
		}
		private void customizeDesign()
		{
			//Menu Design code
			panelMediaSubmenu.Visible = false;
			panelPlaylistSubmenu.Visible = false;
			panelToolsSubmenu.Visible = false;
		}

		private void hideSubMenu()
		{
			//Menu Design code
			if (panelMediaSubmenu.Visible == true)
				panelMediaSubmenu.Visible = false;
			if (panelPlaylistSubmenu.Visible == true)
				panelPlaylistSubmenu.Visible = false;
			if (panelToolsSubmenu.Visible == true)
				panelToolsSubmenu.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			//Menu Design code
			//showSubmenu if you click Top Button
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;


		}

		private void BtnMedia_Click(object sender, EventArgs e)
		{
			showSubMenu(panelMediaSubmenu);
		}
		#region MediaSubmenu
		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new Form2());
			
			//Menu Design code
			hideSubMenu();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button4_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button5_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}
#endregion
		private void BtnPlaylist_Click(object sender, EventArgs e)
		{
			showSubMenu(panelPlaylistSubmenu);
		}
		#region PlaylistSubmenu
		private void button9_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button8_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button7_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button6_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}
#endregion
		private void BtnEqualizer_Click(object sender, EventArgs e)
		{
			openChildForm(new Form3());
			
			//Menu Design code
			hideSubMenu();


		}

		private void BtnTools_Click(object sender, EventArgs e)
		{
			showSubMenu(panelToolsSubmenu);
		}
		#region ToolsSubmenu
		private void button15_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button14_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button13_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void button12_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}
#endregion
		private void BtnHelp_Click(object sender, EventArgs e)
		{
			//Menu Design code
			hideSubMenu();


		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			try
			{
				
				if(v != null)
				{
					if (v.Playing)
					{
						v.Pause();
						timer1.Stop();

					}
					else
					{
						Video v = Video.FromFile(@"C:\CShapProject\PlayerUI\PlayerUI\Resource\CountDown5Seconds.wmv");
						v.Owner = this.panelChildForm;
						v.Play();
						timer1.Start();
					}
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "동영상이 재생되지 않았습니다.");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			PlayingPosition = CalculateTime(v.CurrentPosition);
			txtStatus.Text = PlayingPosition + "/" + Duration;
			if(v.CurrentPosition >= v.Duration)
			{
				timer1.Stop();
				Duration = CalculateTime(v.Duration);
				PlayingPosition = "0:00:00";
				txtStatus.Text = PlayingPosition + "/" + Duration;
				v.Stop();
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (v != null)
			{
				v.Stop();
				timer1.Stop();
				videoTrackBar.Value = 0;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			openFileDialog.Title = "Select Video File..";
			openFileDialog.InitialDirectory = Application.StartupPath;
			openFileDialog.DefaultExt = ".avi";
			openFileDialog.Filter = "Media File|*.mpg;*.avi;*.wma;*.mov;*.wav;*mp4|All Files|*.*";

			if (openFileDialog.FileName != "")
			{
				Form1.ActiveForm.Text = openFileDialog.FileName + "  -Anand Media Player";
				v = new Video(openFileDialog.FileName);
				v.Owner = panelChildForm;
				panelChildForm.Width = 824;
				panelChildForm.Height = 547;
				Duration = CalculateTime(v.Duration);
				PlayingPosition = "0:00:00";
				txtStatus.Text = PlayingPosition + "/" + Duration;
				videoTrackBar.Minimum = 0;
				videoTrackBar.Maximum = Convert.ToInt32(v.Duration);
			}

		}

		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			Duration = CalculateTime(v.Duration);
			PlayingPosition = "0:00:00";
			txtStatus.Text = PlayingPosition + "/" + Duration;
		}

		private void VolumeTrackbar_Scroll(object sender, EventArgs e)
		{
			if (v != null)
			{
				v.Audio.Volume = CalculateVolume();
			}
		}

		public int CalculateVolume()
		{
			switch (VolumeTrackbar.Value)
			{
				case 1:
					return -1500;
				case 2:
					return -1000;
				case 3:
					return -700;
				case 4:
					return -600;
				case 5:
					return -500;
				case 6:
					return -400;
				case 7:
					return -300;
				case 8:
					return -200;
				case 9:
					return -100;
				case 10:
					return 0;
				default:
					return -10000;
			}
		}

		

		public string CalculateTime(double Time)
		{
			string mm, ss, CalculateTime;
			int h, m, s, T;
			Time = Math.Round(Time);
			T = Convert.ToInt32(Time);
			h = (T / 3600);
			T = T % 3600;
			m = (T / 60);
			s = T % 60;
			if (m < 10)
				mm = string.Format("0{0}", m);
			else
				mm = m.ToString();
			if (s < 10)
				ss = string.Format("0{0}", s);
			else
				ss = s.ToString();
			CalculateTime = string.Format("{0}:{1}:{2}", h, mm, ss);
			return CalculateTime;
				
		}
	}
}
