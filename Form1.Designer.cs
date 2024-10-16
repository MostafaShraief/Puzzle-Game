namespace Puzzle_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tc = new System.Windows.Forms.TabControl();
            this.MainMenu = new System.Windows.Forms.TabPage();
            this.btnGitHub = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeleram = new Guna.UI2.WinForms.Guna2Button();
            this.lblDesignerName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnGetUserImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nudColumns = new CodeeloUI.Controls.CodeeloNumericUpDown();
            this.nudRows = new CodeeloUI.Controls.CodeeloNumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsCustomMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsHardMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsMediumMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsEasyMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GameScreen = new System.Windows.Forms.TabPage();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGSShuffle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGSPlayAgain = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lblGSResult = new System.Windows.Forms.Label();
            this.lblGSTime = new System.Windows.Forms.Label();
            this.lblGSMode = new System.Windows.Forms.Label();
            this.lblGSRows = new System.Windows.Forms.Label();
            this.lblGSColumns = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ofdlg = new System.Windows.Forms.OpenFileDialog();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tc.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.cyberGroupBox1.SuspendLayout();
            this.GameScreen.SuspendLayout();
            this.cyberGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.MainMenu);
            this.tc.Controls.Add(this.GameScreen);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1128, 604);
            this.tc.TabIndex = 0;
            this.tc.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(4)))));
            this.MainMenu.BackgroundImage = global::Puzzle_Game.Properties.Resources.Main_Screen_Background;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenu.Controls.Add(this.btnGitHub);
            this.MainMenu.Controls.Add(this.btnTeleram);
            this.MainMenu.Controls.Add(this.lblDesignerName);
            this.MainMenu.Controls.Add(this.lblTitle);
            this.MainMenu.Controls.Add(this.btnStartGame);
            this.MainMenu.Controls.Add(this.cyberGroupBox1);
            this.MainMenu.Controls.Add(this.panel1);
            this.MainMenu.Location = new System.Drawing.Point(4, 25);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenu.Size = new System.Drawing.Size(1120, 575);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackgroundImage = global::Puzzle_Game.Properties.Resources.github;
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGitHub.CheckedState.Parent = this.btnGitHub;
            this.btnGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGitHub.CustomImages.Parent = this.btnGitHub;
            this.btnGitHub.FillColor = System.Drawing.Color.Transparent;
            this.btnGitHub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGitHub.ForeColor = System.Drawing.Color.White;
            this.btnGitHub.HoverState.Parent = this.btnGitHub;
            this.btnGitHub.Location = new System.Drawing.Point(937, 342);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.ShadowDecoration.Parent = this.btnGitHub;
            this.btnGitHub.Size = new System.Drawing.Size(52, 52);
            this.btnGitHub.TabIndex = 16;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnTeleram
            // 
            this.btnTeleram.BackgroundImage = global::Puzzle_Game.Properties.Resources.telegram;
            this.btnTeleram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeleram.CheckedState.Parent = this.btnTeleram;
            this.btnTeleram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeleram.CustomImages.Parent = this.btnTeleram;
            this.btnTeleram.FillColor = System.Drawing.Color.Transparent;
            this.btnTeleram.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTeleram.ForeColor = System.Drawing.Color.White;
            this.btnTeleram.HoverState.Parent = this.btnTeleram;
            this.btnTeleram.Location = new System.Drawing.Point(846, 342);
            this.btnTeleram.Name = "btnTeleram";
            this.btnTeleram.ShadowDecoration.Parent = this.btnTeleram;
            this.btnTeleram.Size = new System.Drawing.Size(52, 52);
            this.btnTeleram.TabIndex = 15;
            this.btnTeleram.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // lblDesignerName
            // 
            this.lblDesignerName.AutoSize = true;
            this.lblDesignerName.Font = new System.Drawing.Font("Nirmala UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignerName.Location = new System.Drawing.Point(748, 274);
            this.lblDesignerName.Name = "lblDesignerName";
            this.lblDesignerName.Size = new System.Drawing.Size(352, 45);
            this.lblDesignerName.TabIndex = 14;
            this.lblDesignerName.Text = "Created By MØSTAFA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(817, 195);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 45);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Sliding Puzzle";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Animated = true;
            this.btnStartGame.AutoRoundedCorners = true;
            this.btnStartGame.BorderRadius = 10;
            this.btnStartGame.CheckedState.Parent = this.btnStartGame;
            this.btnStartGame.CustomImages.Parent = this.btnStartGame;
            this.btnStartGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnStartGame.FillColor2 = System.Drawing.Color.Black;
            this.btnStartGame.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnStartGame.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnStartGame.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnStartGame.HoverState.Parent = this.btnStartGame;
            this.btnStartGame.Location = new System.Drawing.Point(119, 507);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.ShadowDecoration.Parent = this.btnStartGame;
            this.btnStartGame.Size = new System.Drawing.Size(180, 45);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // cyberGroupBox1
            // 
            this.cyberGroupBox1.Alpha = 20;
            this.cyberGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox1.Background = true;
            this.cyberGroupBox1.Background_WidthPen = 3F;
            this.cyberGroupBox1.BackgroundPen = true;
            this.cyberGroupBox1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_2 = System.Drawing.Color.Black;
            this.cyberGroupBox1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox1.ColorLighting = System.Drawing.Color.Black;
            this.cyberGroupBox1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorPen_2 = System.Drawing.Color.Black;
            this.cyberGroupBox1.Controls.Add(this.lblColumns);
            this.cyberGroupBox1.Controls.Add(this.lblRow);
            this.cyberGroupBox1.Controls.Add(this.btnGetUserImage);
            this.cyberGroupBox1.Controls.Add(this.nudColumns);
            this.cyberGroupBox1.Controls.Add(this.nudRows);
            this.cyberGroupBox1.Controls.Add(this.label5);
            this.cyberGroupBox1.Controls.Add(this.label4);
            this.cyberGroupBox1.Controls.Add(this.label3);
            this.cyberGroupBox1.Controls.Add(this.label2);
            this.cyberGroupBox1.Controls.Add(this.tsCustomMode);
            this.cyberGroupBox1.Controls.Add(this.tsHardMode);
            this.cyberGroupBox1.Controls.Add(this.tsMediumMode);
            this.cyberGroupBox1.Controls.Add(this.tsEasyMode);
            this.cyberGroupBox1.Controls.Add(this.label1);
            this.cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox1.Lighting = true;
            this.cyberGroupBox1.LinearGradient_Background = true;
            this.cyberGroupBox1.LinearGradientPen = true;
            this.cyberGroupBox1.Location = new System.Drawing.Point(55, 86);
            this.cyberGroupBox1.Name = "cyberGroupBox1";
            this.cyberGroupBox1.PenWidth = 15;
            this.cyberGroupBox1.RGB = false;
            this.cyberGroupBox1.Rounding = true;
            this.cyberGroupBox1.RoundingInt = 10;
            this.cyberGroupBox1.Size = new System.Drawing.Size(322, 374);
            this.cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox1.TabIndex = 3;
            this.cyberGroupBox1.Tag = "Cyber";
            this.cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox1.Timer_RGB = 300;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblColumns.Location = new System.Drawing.Point(127, 337);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(103, 29);
            this.lblColumns.TabIndex = 14;
            this.lblColumns.Text = "Columns";
            this.lblColumns.Visible = false;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblRow.Location = new System.Drawing.Point(37, 337);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(58, 29);
            this.lblRow.TabIndex = 13;
            this.lblRow.Text = "Row";
            this.lblRow.Visible = false;
            // 
            // btnGetUserImage
            // 
            this.btnGetUserImage.AutoRoundedCorners = true;
            this.btnGetUserImage.BorderRadius = 15;
            this.btnGetUserImage.CheckedState.Parent = this.btnGetUserImage;
            this.btnGetUserImage.CustomImages.Parent = this.btnGetUserImage;
            this.btnGetUserImage.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGetUserImage.FillColor2 = System.Drawing.Color.Blue;
            this.btnGetUserImage.Font = new System.Drawing.Font("IOS 15 R SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGetUserImage.ForeColor = System.Drawing.Color.White;
            this.btnGetUserImage.HoverState.Parent = this.btnGetUserImage;
            this.btnGetUserImage.Location = new System.Drawing.Point(240, 302);
            this.btnGetUserImage.Name = "btnGetUserImage";
            this.btnGetUserImage.ShadowDecoration.Parent = this.btnGetUserImage;
            this.btnGetUserImage.Size = new System.Drawing.Size(69, 32);
            this.btnGetUserImage.TabIndex = 7;
            this.btnGetUserImage.Text = "Image";
            this.btnGetUserImage.Visible = false;
            this.btnGetUserImage.Click += new System.EventHandler(this.btnGetUserImage_Click);
            // 
            // nudColumns
            // 
            this.nudColumns.AccessibleRole = null;
            this.nudColumns.BackColor = System.Drawing.Color.Transparent;
            this.nudColumns.BackgroundImage = false;
            this.nudColumns.BackgroundImageLayout = false;
            this.nudColumns.CausesValidation = false;
            this.nudColumns.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.nudColumns.FillColorSecond = System.Drawing.Color.Blue;
            this.nudColumns.Font = new System.Drawing.Font("IOS 15 R SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.nudColumns.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.nudColumns.Interval = 1;
            this.nudColumns.Location = new System.Drawing.Point(128, 302);
            this.nudColumns.MaxValue = 8;
            this.nudColumns.MinValue = 2;
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Radius = 15;
            this.nudColumns.Size = new System.Drawing.Size(100, 32);
            this.nudColumns.TabIndex = 6;
            this.nudColumns.TabStop = false;
            this.nudColumns.Text = "codeeloNumericUpDown2";
            this.nudColumns.Value = 2;
            this.nudColumns.Visible = false;
            // 
            // nudRows
            // 
            this.nudRows.AccessibleRole = null;
            this.nudRows.BackColor = System.Drawing.Color.Transparent;
            this.nudRows.BackgroundImage = false;
            this.nudRows.BackgroundImageLayout = false;
            this.nudRows.CausesValidation = false;
            this.nudRows.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.nudRows.FillColorSecond = System.Drawing.Color.Blue;
            this.nudRows.Font = new System.Drawing.Font("IOS 15 R SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.nudRows.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.nudRows.Interval = 1;
            this.nudRows.Location = new System.Drawing.Point(16, 302);
            this.nudRows.MaxValue = 8;
            this.nudRows.MinValue = 2;
            this.nudRows.Name = "nudRows";
            this.nudRows.Radius = 15;
            this.nudRows.Size = new System.Drawing.Size(100, 32);
            this.nudRows.TabIndex = 5;
            this.nudRows.TabStop = false;
            this.nudRows.Text = "codeeloNumericUpDown1";
            this.nudRows.Value = 2;
            this.nudRows.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(132, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Custom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(147, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(131, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(148, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Easy";
            // 
            // tsCustomMode
            // 
            this.tsCustomMode.Animated = true;
            this.tsCustomMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsCustomMode.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.tsCustomMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCustomMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCustomMode.CheckedState.Parent = this.tsCustomMode;
            this.tsCustomMode.Location = new System.Drawing.Point(49, 260);
            this.tsCustomMode.Name = "tsCustomMode";
            this.tsCustomMode.ShadowDecoration.Parent = this.tsCustomMode;
            this.tsCustomMode.Size = new System.Drawing.Size(35, 20);
            this.tsCustomMode.TabIndex = 4;
            this.tsCustomMode.Tag = "Custom";
            this.tsCustomMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsCustomMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsCustomMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCustomMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCustomMode.UncheckedState.Parent = this.tsCustomMode;
            this.tsCustomMode.CheckedChanged += new System.EventHandler(this.ToggleSwitchClick);
            // 
            // tsHardMode
            // 
            this.tsHardMode.Animated = true;
            this.tsHardMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsHardMode.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.tsHardMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsHardMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsHardMode.CheckedState.Parent = this.tsHardMode;
            this.tsHardMode.Location = new System.Drawing.Point(49, 205);
            this.tsHardMode.Name = "tsHardMode";
            this.tsHardMode.ShadowDecoration.Parent = this.tsHardMode;
            this.tsHardMode.Size = new System.Drawing.Size(35, 20);
            this.tsHardMode.TabIndex = 3;
            this.tsHardMode.Tag = "Hard";
            this.tsHardMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsHardMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsHardMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsHardMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsHardMode.UncheckedState.Parent = this.tsHardMode;
            this.tsHardMode.CheckedChanged += new System.EventHandler(this.ToggleSwitchClick);
            // 
            // tsMediumMode
            // 
            this.tsMediumMode.Animated = true;
            this.tsMediumMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsMediumMode.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.tsMediumMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsMediumMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsMediumMode.CheckedState.Parent = this.tsMediumMode;
            this.tsMediumMode.Location = new System.Drawing.Point(49, 150);
            this.tsMediumMode.Name = "tsMediumMode";
            this.tsMediumMode.ShadowDecoration.Parent = this.tsMediumMode;
            this.tsMediumMode.Size = new System.Drawing.Size(35, 20);
            this.tsMediumMode.TabIndex = 2;
            this.tsMediumMode.Tag = "Medium";
            this.tsMediumMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsMediumMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsMediumMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsMediumMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsMediumMode.UncheckedState.Parent = this.tsMediumMode;
            this.tsMediumMode.CheckedChanged += new System.EventHandler(this.ToggleSwitchClick);
            // 
            // tsEasyMode
            // 
            this.tsEasyMode.Animated = true;
            this.tsEasyMode.CheckedState.BorderColor = System.Drawing.Color.White;
            this.tsEasyMode.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.tsEasyMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsEasyMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsEasyMode.CheckedState.Parent = this.tsEasyMode;
            this.tsEasyMode.Location = new System.Drawing.Point(49, 95);
            this.tsEasyMode.Name = "tsEasyMode";
            this.tsEasyMode.ShadowDecoration.Parent = this.tsEasyMode;
            this.tsEasyMode.Size = new System.Drawing.Size(35, 20);
            this.tsEasyMode.TabIndex = 1;
            this.tsEasyMode.Tag = "Easy";
            this.tsEasyMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsEasyMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsEasyMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsEasyMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsEasyMode.UncheckedState.Parent = this.tsEasyMode;
            this.tsEasyMode.CheckedChanged += new System.EventHandler(this.ToggleSwitchClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 569);
            this.panel1.TabIndex = 2;
            // 
            // GameScreen
            // 
            this.GameScreen.BackgroundImage = global::Puzzle_Game.Properties.Resources.Game_Screen_Background;
            this.GameScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameScreen.Controls.Add(this.guna2GradientButton1);
            this.GameScreen.Controls.Add(this.btnGSShuffle);
            this.GameScreen.Controls.Add(this.btnGSPlayAgain);
            this.GameScreen.Controls.Add(this.cyberGroupBox2);
            this.GameScreen.Controls.Add(this.pbOriginalImage);
            this.GameScreen.Controls.Add(this.tlp);
            this.GameScreen.Location = new System.Drawing.Point(4, 25);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Padding = new System.Windows.Forms.Padding(3);
            this.GameScreen.Size = new System.Drawing.Size(1120, 575);
            this.GameScreen.TabIndex = 0;
            this.GameScreen.Text = "Game Screen";
            this.GameScreen.UseVisualStyleBackColor = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2GradientButton1.Font = new System.Drawing.Font("IOS 15 R SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(8, 12);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(44, 44);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.TabStop = false;
            this.guna2GradientButton1.Text = "<";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnGSShuffle
            // 
            this.btnGSShuffle.Animated = true;
            this.btnGSShuffle.AutoRoundedCorners = true;
            this.btnGSShuffle.BorderRadius = 21;
            this.btnGSShuffle.BorderThickness = 2;
            this.btnGSShuffle.CheckedState.Parent = this.btnGSShuffle;
            this.btnGSShuffle.CustomImages.Parent = this.btnGSShuffle;
            this.btnGSShuffle.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGSShuffle.FillColor2 = System.Drawing.Color.Blue;
            this.btnGSShuffle.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnGSShuffle.ForeColor = System.Drawing.Color.Black;
            this.btnGSShuffle.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnGSShuffle.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnGSShuffle.HoverState.FillColor2 = System.Drawing.Color.MediumSlateBlue;
            this.btnGSShuffle.HoverState.Parent = this.btnGSShuffle;
            this.btnGSShuffle.Location = new System.Drawing.Point(359, 510);
            this.btnGSShuffle.Name = "btnGSShuffle";
            this.btnGSShuffle.ShadowDecoration.Parent = this.btnGSShuffle;
            this.btnGSShuffle.Size = new System.Drawing.Size(191, 45);
            this.btnGSShuffle.TabIndex = 6;
            this.btnGSShuffle.TabStop = false;
            this.btnGSShuffle.Text = "Shuffle";
            this.btnGSShuffle.Click += new System.EventHandler(this.btnGSShuffle_Click);
            // 
            // btnGSPlayAgain
            // 
            this.btnGSPlayAgain.Animated = true;
            this.btnGSPlayAgain.AutoRoundedCorners = true;
            this.btnGSPlayAgain.BorderRadius = 21;
            this.btnGSPlayAgain.BorderThickness = 2;
            this.btnGSPlayAgain.CheckedState.Parent = this.btnGSPlayAgain;
            this.btnGSPlayAgain.CustomImages.Parent = this.btnGSPlayAgain;
            this.btnGSPlayAgain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGSPlayAgain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.btnGSPlayAgain.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnGSPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnGSPlayAgain.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnGSPlayAgain.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.btnGSPlayAgain.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGSPlayAgain.HoverState.Parent = this.btnGSPlayAgain;
            this.btnGSPlayAgain.Location = new System.Drawing.Point(40, 510);
            this.btnGSPlayAgain.Name = "btnGSPlayAgain";
            this.btnGSPlayAgain.ShadowDecoration.Parent = this.btnGSPlayAgain;
            this.btnGSPlayAgain.Size = new System.Drawing.Size(191, 45);
            this.btnGSPlayAgain.TabIndex = 5;
            this.btnGSPlayAgain.Text = "Play Again";
            this.btnGSPlayAgain.Click += new System.EventHandler(this.btnGSPlayAgain_Click);
            // 
            // cyberGroupBox2
            // 
            this.cyberGroupBox2.Alpha = 20;
            this.cyberGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox2.Background = true;
            this.cyberGroupBox2.Background_WidthPen = 3F;
            this.cyberGroupBox2.BackgroundPen = true;
            this.cyberGroupBox2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorBackground_2 = System.Drawing.Color.Black;
            this.cyberGroupBox2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox2.ColorLighting = System.Drawing.Color.Black;
            this.cyberGroupBox2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorPen_2 = System.Drawing.Color.Black;
            this.cyberGroupBox2.Controls.Add(this.lblGSResult);
            this.cyberGroupBox2.Controls.Add(this.lblGSTime);
            this.cyberGroupBox2.Controls.Add(this.lblGSMode);
            this.cyberGroupBox2.Controls.Add(this.lblGSRows);
            this.cyberGroupBox2.Controls.Add(this.lblGSColumns);
            this.cyberGroupBox2.Controls.Add(this.label10);
            this.cyberGroupBox2.Controls.Add(this.label9);
            this.cyberGroupBox2.Controls.Add(this.label8);
            this.cyberGroupBox2.Controls.Add(this.label7);
            this.cyberGroupBox2.Controls.Add(this.label6);
            this.cyberGroupBox2.Controls.Add(this.label12);
            this.cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox2.Lighting = true;
            this.cyberGroupBox2.LinearGradient_Background = true;
            this.cyberGroupBox2.LinearGradientPen = true;
            this.cyberGroupBox2.Location = new System.Drawing.Point(40, 93);
            this.cyberGroupBox2.Name = "cyberGroupBox2";
            this.cyberGroupBox2.PenWidth = 15;
            this.cyberGroupBox2.RGB = false;
            this.cyberGroupBox2.Rounding = true;
            this.cyberGroupBox2.RoundingInt = 10;
            this.cyberGroupBox2.Size = new System.Drawing.Size(191, 400);
            this.cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox2.TabIndex = 4;
            this.cyberGroupBox2.TabStop = false;
            this.cyberGroupBox2.Tag = "Cyber";
            this.cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox2.Timer_RGB = 300;
            // 
            // lblGSResult
            // 
            this.lblGSResult.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSResult.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGSResult.Location = new System.Drawing.Point(25, 341);
            this.lblGSResult.Name = "lblGSResult";
            this.lblGSResult.Size = new System.Drawing.Size(132, 29);
            this.lblGSResult.TabIndex = 15;
            this.lblGSResult.Text = "Pending";
            this.lblGSResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGSTime
            // 
            this.lblGSTime.AutoSize = true;
            this.lblGSTime.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblGSTime.Location = new System.Drawing.Point(87, 239);
            this.lblGSTime.Name = "lblGSTime";
            this.lblGSTime.Size = new System.Drawing.Size(28, 29);
            this.lblGSTime.TabIndex = 14;
            this.lblGSTime.Text = "0";
            // 
            // lblGSMode
            // 
            this.lblGSMode.AutoSize = true;
            this.lblGSMode.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblGSMode.Location = new System.Drawing.Point(92, 86);
            this.lblGSMode.Name = "lblGSMode";
            this.lblGSMode.Size = new System.Drawing.Size(28, 29);
            this.lblGSMode.TabIndex = 13;
            this.lblGSMode.Text = "0";
            // 
            // lblGSRows
            // 
            this.lblGSRows.AutoSize = true;
            this.lblGSRows.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblGSRows.Location = new System.Drawing.Point(94, 137);
            this.lblGSRows.Name = "lblGSRows";
            this.lblGSRows.Size = new System.Drawing.Size(28, 29);
            this.lblGSRows.TabIndex = 12;
            this.lblGSRows.Text = "0";
            // 
            // lblGSColumns
            // 
            this.lblGSColumns.AutoSize = true;
            this.lblGSColumns.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSColumns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblGSColumns.Location = new System.Drawing.Point(129, 188);
            this.lblGSColumns.Name = "lblGSColumns";
            this.lblGSColumns.Size = new System.Drawing.Size(28, 29);
            this.lblGSColumns.TabIndex = 11;
            this.lblGSColumns.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(20, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Result:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label9.Location = new System.Drawing.Point(20, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(20, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Columns:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(20, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rows:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mode:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label12.Location = new System.Drawing.Point(33, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 45);
            this.label12.TabIndex = 0;
            this.label12.Text = "Status";
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.Location = new System.Drawing.Point(677, 93);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(400, 400);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginalImage.TabIndex = 1;
            this.pbOriginalImage.TabStop = false;
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Location = new System.Drawing.Point(254, 93);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(400, 400);
            this.tlp.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClose);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1128, 32);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 15;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1052, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(66, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(381, 32);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // ofdlg
            // 
            this.ofdlg.FileName = " ";
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(1118, 32);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(10, 572);
            this.guna2CustomGradientPanel3.TabIndex = 1;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(0, 32);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(10, 562);
            this.guna2CustomGradientPanel4.TabIndex = 2;
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel5.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel5.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(0, 594);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.ShadowDecoration.Parent = this.guna2CustomGradientPanel5;
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(1118, 10);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 604);
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel5);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox1.PerformLayout();
            this.GameScreen.ResumeLayout(false);
            this.cyberGroupBox2.ResumeLayout(false);
            this.cyberGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage GameScreen;
        private System.Windows.Forms.TabPage MainMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartGame;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsEasyMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsCustomMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsHardMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsMediumMode;
        private CodeeloUI.Controls.CodeeloNumericUpDown nudColumns;
        private CodeeloUI.Controls.CodeeloNumericUpDown nudRows;
        private Guna.UI2.WinForms.Guna2GradientButton btnGetUserImage;
        private System.Windows.Forms.Label lblDesignerName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.OpenFileDialog ofdlg;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGSResult;
        private System.Windows.Forms.Label lblGSTime;
        private System.Windows.Forms.Label lblGSMode;
        private System.Windows.Forms.Label lblGSRows;
        private System.Windows.Forms.Label lblGSColumns;
        private Guna.UI2.WinForms.Guna2GradientButton btnGSPlayAgain;
        private System.Windows.Forms.Timer tmr;
        private Guna.UI2.WinForms.Guna2GradientButton btnGSShuffle;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnTeleram;
        private Guna.UI2.WinForms.Guna2Button btnGitHub;
    }
}

