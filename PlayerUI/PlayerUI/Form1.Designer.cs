namespace PlayerUI
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.BtnClose = new System.Windows.Forms.Button();
			this.BtnHelp = new System.Windows.Forms.Button();
			this.panelToolsSubmenu = new System.Windows.Forms.Panel();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.BtnTools = new System.Windows.Forms.Button();
			this.BtnEqualizer = new System.Windows.Forms.Button();
			this.panelPlaylistSubmenu = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.BtnPlaylist = new System.Windows.Forms.Button();
			this.panelMediaSubmenu = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.BtnMedia = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelPlayer = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.VolumeTrackbar = new System.Windows.Forms.TrackBar();
			this.videoTrackBar = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelSideMenu.SuspendLayout();
			this.panelToolsSubmenu.SuspendLayout();
			this.panelPlaylistSubmenu.SuspendLayout();
			this.panelMediaSubmenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelPlayer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panelChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackbar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(7)))));
			this.panelSideMenu.Controls.Add(this.BtnClose);
			this.panelSideMenu.Controls.Add(this.BtnHelp);
			this.panelSideMenu.Controls.Add(this.panelToolsSubmenu);
			this.panelSideMenu.Controls.Add(this.BtnTools);
			this.panelSideMenu.Controls.Add(this.BtnEqualizer);
			this.panelSideMenu.Controls.Add(this.panelPlaylistSubmenu);
			this.panelSideMenu.Controls.Add(this.BtnPlaylist);
			this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
			this.panelSideMenu.Controls.Add(this.BtnMedia);
			this.panelSideMenu.Controls.Add(this.panelLogo);
			this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(250, 666);
			this.panelSideMenu.TabIndex = 0;
			// 
			// BtnClose
			// 
			this.BtnClose.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnClose.FlatAppearance.BorderSize = 0;
			this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnClose.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnClose.Location = new System.Drawing.Point(0, 917);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnClose.Size = new System.Drawing.Size(250, 45);
			this.BtnClose.TabIndex = 9;
			this.BtnClose.Text = "Close";
			this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// BtnHelp
			// 
			this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnHelp.FlatAppearance.BorderSize = 0;
			this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHelp.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnHelp.Location = new System.Drawing.Point(0, 872);
			this.BtnHelp.Name = "BtnHelp";
			this.BtnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnHelp.Size = new System.Drawing.Size(250, 45);
			this.BtnHelp.TabIndex = 8;
			this.BtnHelp.Text = "Help";
			this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnHelp.UseVisualStyleBackColor = true;
			this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
			// 
			// panelToolsSubmenu
			// 
			this.panelToolsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelToolsSubmenu.Controls.Add(this.button12);
			this.panelToolsSubmenu.Controls.Add(this.button13);
			this.panelToolsSubmenu.Controls.Add(this.button14);
			this.panelToolsSubmenu.Controls.Add(this.button15);
			this.panelToolsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelToolsSubmenu.Location = new System.Drawing.Point(0, 685);
			this.panelToolsSubmenu.Name = "panelToolsSubmenu";
			this.panelToolsSubmenu.Size = new System.Drawing.Size(250, 187);
			this.panelToolsSubmenu.TabIndex = 7;
			// 
			// button12
			// 
			this.button12.Dock = System.Windows.Forms.DockStyle.Top;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.ForeColor = System.Drawing.Color.LightGray;
			this.button12.Location = new System.Drawing.Point(0, 135);
			this.button12.Name = "button12";
			this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button12.Size = new System.Drawing.Size(250, 45);
			this.button12.TabIndex = 3;
			this.button12.Text = "button12";
			this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button13
			// 
			this.button13.Dock = System.Windows.Forms.DockStyle.Top;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.ForeColor = System.Drawing.Color.LightGray;
			this.button13.Location = new System.Drawing.Point(0, 90);
			this.button13.Name = "button13";
			this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button13.Size = new System.Drawing.Size(250, 45);
			this.button13.TabIndex = 2;
			this.button13.Text = "button13";
			this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button14
			// 
			this.button14.Dock = System.Windows.Forms.DockStyle.Top;
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.ForeColor = System.Drawing.Color.LightGray;
			this.button14.Location = new System.Drawing.Point(0, 45);
			this.button14.Name = "button14";
			this.button14.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button14.Size = new System.Drawing.Size(250, 45);
			this.button14.TabIndex = 1;
			this.button14.Text = "button14";
			this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// button15
			// 
			this.button15.Dock = System.Windows.Forms.DockStyle.Top;
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.ForeColor = System.Drawing.Color.LightGray;
			this.button15.Location = new System.Drawing.Point(0, 0);
			this.button15.Name = "button15";
			this.button15.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button15.Size = new System.Drawing.Size(250, 45);
			this.button15.TabIndex = 0;
			this.button15.Text = "button15";
			this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// BtnTools
			// 
			this.BtnTools.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnTools.FlatAppearance.BorderSize = 0;
			this.BtnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnTools.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnTools.Location = new System.Drawing.Point(0, 640);
			this.BtnTools.Name = "BtnTools";
			this.BtnTools.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnTools.Size = new System.Drawing.Size(250, 45);
			this.BtnTools.TabIndex = 6;
			this.BtnTools.Text = "Tools";
			this.BtnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnTools.UseVisualStyleBackColor = true;
			this.BtnTools.Click += new System.EventHandler(this.BtnTools_Click);
			// 
			// BtnEqualizer
			// 
			this.BtnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnEqualizer.FlatAppearance.BorderSize = 0;
			this.BtnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnEqualizer.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnEqualizer.Location = new System.Drawing.Point(0, 595);
			this.BtnEqualizer.Name = "BtnEqualizer";
			this.BtnEqualizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnEqualizer.Size = new System.Drawing.Size(250, 45);
			this.BtnEqualizer.TabIndex = 5;
			this.BtnEqualizer.Text = "Equalizer";
			this.BtnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnEqualizer.UseVisualStyleBackColor = true;
			this.BtnEqualizer.Click += new System.EventHandler(this.BtnEqualizer_Click);
			// 
			// panelPlaylistSubmenu
			// 
			this.panelPlaylistSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelPlaylistSubmenu.Controls.Add(this.button6);
			this.panelPlaylistSubmenu.Controls.Add(this.button7);
			this.panelPlaylistSubmenu.Controls.Add(this.button8);
			this.panelPlaylistSubmenu.Controls.Add(this.button9);
			this.panelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPlaylistSubmenu.Location = new System.Drawing.Point(0, 408);
			this.panelPlaylistSubmenu.Name = "panelPlaylistSubmenu";
			this.panelPlaylistSubmenu.Size = new System.Drawing.Size(250, 187);
			this.panelPlaylistSubmenu.TabIndex = 4;
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.LightGray;
			this.button6.Location = new System.Drawing.Point(0, 135);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(250, 45);
			this.button6.TabIndex = 3;
			this.button6.Text = "button6";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Top;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.Color.LightGray;
			this.button7.Location = new System.Drawing.Point(0, 90);
			this.button7.Name = "button7";
			this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button7.Size = new System.Drawing.Size(250, 45);
			this.button7.TabIndex = 2;
			this.button7.Text = "button7";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Dock = System.Windows.Forms.DockStyle.Top;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.Color.LightGray;
			this.button8.Location = new System.Drawing.Point(0, 45);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button8.Size = new System.Drawing.Size(250, 45);
			this.button8.TabIndex = 1;
			this.button8.Text = "button8";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Dock = System.Windows.Forms.DockStyle.Top;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.ForeColor = System.Drawing.Color.LightGray;
			this.button9.Location = new System.Drawing.Point(0, 0);
			this.button9.Name = "button9";
			this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button9.Size = new System.Drawing.Size(250, 45);
			this.button9.TabIndex = 0;
			this.button9.Text = "button9";
			this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// BtnPlaylist
			// 
			this.BtnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnPlaylist.FlatAppearance.BorderSize = 0;
			this.BtnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnPlaylist.Location = new System.Drawing.Point(0, 363);
			this.BtnPlaylist.Name = "BtnPlaylist";
			this.BtnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnPlaylist.Size = new System.Drawing.Size(250, 45);
			this.BtnPlaylist.TabIndex = 3;
			this.BtnPlaylist.Text = "Playlist management";
			this.BtnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnPlaylist.UseVisualStyleBackColor = true;
			this.BtnPlaylist.Click += new System.EventHandler(this.BtnPlaylist_Click);
			// 
			// panelMediaSubmenu
			// 
			this.panelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelMediaSubmenu.Controls.Add(this.button5);
			this.panelMediaSubmenu.Controls.Add(this.button4);
			this.panelMediaSubmenu.Controls.Add(this.button3);
			this.panelMediaSubmenu.Controls.Add(this.button2);
			this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 176);
			this.panelMediaSubmenu.Name = "panelMediaSubmenu";
			this.panelMediaSubmenu.Size = new System.Drawing.Size(250, 187);
			this.panelMediaSubmenu.TabIndex = 2;
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(0, 135);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(250, 45);
			this.button5.TabIndex = 3;
			this.button5.Text = "button5";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.LightGray;
			this.button4.Location = new System.Drawing.Point(0, 90);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(250, 45);
			this.button4.TabIndex = 2;
			this.button4.Text = "button4";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.LightGray;
			this.button3.Location = new System.Drawing.Point(0, 45);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(250, 45);
			this.button3.TabIndex = 1;
			this.button3.Text = "button3";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.LightGray;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(250, 45);
			this.button2.TabIndex = 0;
			this.button2.Text = "button2";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// BtnMedia
			// 
			this.BtnMedia.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnMedia.FlatAppearance.BorderSize = 0;
			this.BtnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMedia.ForeColor = System.Drawing.Color.Gainsboro;
			this.BtnMedia.Location = new System.Drawing.Point(0, 131);
			this.BtnMedia.Name = "BtnMedia";
			this.BtnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.BtnMedia.Size = new System.Drawing.Size(250, 45);
			this.BtnMedia.TabIndex = 1;
			this.BtnMedia.Text = "Media";
			this.BtnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnMedia.UseVisualStyleBackColor = true;
			this.BtnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.pictureBox2);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(250, 131);
			this.panelLogo.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(38, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(167, 101);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// panelPlayer
			// 
			this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
			this.panelPlayer.Controls.Add(this.videoTrackBar);
			this.panelPlayer.Controls.Add(this.VolumeTrackbar);
			this.panelPlayer.Controls.Add(this.txtStatus);
			this.panelPlayer.Controls.Add(this.button1);
			this.panelPlayer.Controls.Add(this.pictureBox3);
			this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelPlayer.Location = new System.Drawing.Point(250, 547);
			this.panelPlayer.Name = "panelPlayer";
			this.panelPlayer.Size = new System.Drawing.Size(824, 119);
			this.panelPlayer.TabIndex = 1;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(355, 57);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(95, 47);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.panelChildForm.Controls.Add(this.pictureBox1);
			this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChildForm.Location = new System.Drawing.Point(250, 0);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(824, 547);
			this.panelChildForm.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(587, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(211, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Find Video";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(587, 57);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(211, 21);
			this.txtStatus.TabIndex = 2;
			// 
			// VolumeTrackbar
			// 
			this.VolumeTrackbar.Location = new System.Drawing.Point(119, 57);
			this.VolumeTrackbar.Name = "VolumeTrackbar";
			this.VolumeTrackbar.Size = new System.Drawing.Size(104, 45);
			this.VolumeTrackbar.TabIndex = 3;
			this.VolumeTrackbar.Scroll += new System.EventHandler(this.VolumeTrackbar_Scroll);
			// 
			// videoTrackBar
			// 
			this.videoTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.videoTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.videoTrackBar.Location = new System.Drawing.Point(0, 0);
			this.videoTrackBar.Maximum = 20;
			this.videoTrackBar.Name = "videoTrackBar";
			this.videoTrackBar.Size = new System.Drawing.Size(824, 45);
			this.videoTrackBar.TabIndex = 4;
			this.videoTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(290, 176);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(246, 199);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 666);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panelPlayer);
			this.Controls.Add(this.panelSideMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1090, 705);
			this.Name = "Form1";
			this.Text = "PlayerUI";
			this.panelSideMenu.ResumeLayout(false);
			this.panelToolsSubmenu.ResumeLayout(false);
			this.panelPlaylistSubmenu.ResumeLayout(false);
			this.panelMediaSubmenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelPlayer.ResumeLayout(false);
			this.panelPlayer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panelChildForm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackbar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.Button BtnHelp;
		private System.Windows.Forms.Panel panelToolsSubmenu;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button BtnTools;
		private System.Windows.Forms.Button BtnEqualizer;
		private System.Windows.Forms.Panel panelPlaylistSubmenu;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button BtnPlaylist;
		private System.Windows.Forms.Panel panelMediaSubmenu;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button BtnMedia;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelPlayer;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.TrackBar VolumeTrackbar;
		private System.Windows.Forms.TrackBar videoTrackBar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

