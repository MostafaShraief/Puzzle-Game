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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tc = new System.Windows.Forms.TabControl();
            this.MainMenu = new System.Windows.Forms.TabPage();
            this.lblDesignerName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnGetUserImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nudColumns = new CodeeloUI.Controls.CodeeloNumericUpDown();
            this.nudRow = new CodeeloUI.Controls.CodeeloNumericUpDown();
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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tc.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.cyberGroupBox1.SuspendLayout();
            this.GameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tc
            // 
            this.tc.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc.Controls.Add(this.MainMenu);
            this.tc.Controls.Add(this.GameScreen);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1128, 604);
            this.tc.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(4)))));
            this.MainMenu.BackgroundImage = global::Puzzle_Game.Properties.Resources.daniele_franchi_dt0yhDQmJ4k_unsplash;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenu.Controls.Add(this.lblDesignerName);
            this.MainMenu.Controls.Add(this.lblTitle);
            this.MainMenu.Controls.Add(this.btnStartGame);
            this.MainMenu.Controls.Add(this.cyberGroupBox1);
            this.MainMenu.Controls.Add(this.panel1);
            this.MainMenu.Location = new System.Drawing.Point(4, 4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenu.Size = new System.Drawing.Size(1120, 575);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
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
            this.lblTitle.Size = new System.Drawing.Size(217, 45);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Puzzle Game";
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
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btnStartGame.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnStartGame.HoverState.Parent = this.btnStartGame;
            this.btnStartGame.Location = new System.Drawing.Point(119, 507);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.ShadowDecoration.Parent = this.btnStartGame;
            this.btnStartGame.Size = new System.Drawing.Size(180, 45);
            this.btnStartGame.TabIndex = 4;
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
            this.cyberGroupBox1.Controls.Add(this.nudRow);
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
            this.btnGetUserImage.TabIndex = 12;
            this.btnGetUserImage.Text = "Image";
            this.btnGetUserImage.Visible = false;
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
            this.nudColumns.Interval = 10;
            this.nudColumns.Location = new System.Drawing.Point(128, 302);
            this.nudColumns.MaxValue = 8;
            this.nudColumns.MinValue = 2;
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Radius = 15;
            this.nudColumns.Size = new System.Drawing.Size(100, 32);
            this.nudColumns.TabIndex = 10;
            this.nudColumns.TabStop = false;
            this.nudColumns.Text = "codeeloNumericUpDown2";
            this.nudColumns.Value = 2;
            this.nudColumns.Visible = false;
            // 
            // nudRow
            // 
            this.nudRow.AccessibleRole = null;
            this.nudRow.BackColor = System.Drawing.Color.Transparent;
            this.nudRow.BackgroundImage = false;
            this.nudRow.BackgroundImageLayout = false;
            this.nudRow.CausesValidation = false;
            this.nudRow.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.nudRow.FillColorSecond = System.Drawing.Color.Blue;
            this.nudRow.Font = new System.Drawing.Font("IOS 15 R SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.nudRow.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.nudRow.Interval = 10;
            this.nudRow.Location = new System.Drawing.Point(16, 302);
            this.nudRow.MaxValue = 8;
            this.nudRow.MinValue = 2;
            this.nudRow.Name = "nudRow";
            this.nudRow.Radius = 15;
            this.nudRow.Size = new System.Drawing.Size(100, 32);
            this.nudRow.TabIndex = 9;
            this.nudRow.TabStop = false;
            this.nudRow.Text = "codeeloNumericUpDown1";
            this.nudRow.Value = 2;
            this.nudRow.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IOS 15 R SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GameScreen.BackgroundImage = global::Puzzle_Game.Properties.Resources.oliver_guhr_Qs3ALnjkwF4_unsplash;
            this.GameScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameScreen.Controls.Add(this.pictureBox1);
            this.GameScreen.Controls.Add(this.tlp);
            this.GameScreen.Location = new System.Drawing.Point(4, 4);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Padding = new System.Windows.Forms.Padding(3);
            this.GameScreen.Size = new System.Drawing.Size(1120, 575);
            this.GameScreen.TabIndex = 0;
            this.GameScreen.Text = "Game Screen";
            this.GameScreen.UseVisualStyleBackColor = true;
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Location = new System.Drawing.Point(228, 93);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(400, 400);
            this.tlp.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(671, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 604);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox1.PerformLayout();
            this.GameScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private CodeeloUI.Controls.CodeeloNumericUpDown nudRow;
        private Guna.UI2.WinForms.Guna2GradientButton btnGetUserImage;
        private System.Windows.Forms.Label lblDesignerName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

