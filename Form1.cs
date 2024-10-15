using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Puzzle_Game.Properties;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPictureBox = System.Windows.Forms.PictureBox;
using GunaPictureBox = Guna.UI2.WinForms.Suite.PictureBox;
using Button = System.Windows.Forms.Button;
using WPictureBox = System.Windows.Forms.PictureBox;
using System.IO;
using System.Security.Cryptography;


namespace Puzzle_Game
{

    struct stGameSettings
    {

        public int Rows, Columns;
        public Bitmap Image;

        public stGameSettings(int rows, int columns, Bitmap image)
        {
            Rows = rows;
            Columns = columns;
            Image = image;
        }

    }

    public partial class Form1 : Form
    {

        List<List<Button>> listImageButtons;

        stGameSettings GameSettings;

        Bitmap SelectedFileImage;

        public Form1()
        {
            InitializeComponent();
        }

        void SetGameSettings()
        {

            if (tsEasyMode.Checked)
            {
                GameSettings = new stGameSettings(2, 2,
                    Resources.Cat);
            }
            else if (tsMediumMode.Checked)
            {
                GameSettings = new stGameSettings(3, 3,
                    Resources.Cat);
            }
            else if (tsHardMode.Checked)
            {
                GameSettings = new stGameSettings(4, 4,
                    Resources.Cat);
            }
            else if (tsCustomMode.Checked)
            {
                if (SelectedFileImage == null)
                    SelectedFileImage = Resources.Cat;

                GameSettings = new stGameSettings(nudRows.Value, nudColumns.Value,
                    SelectedFileImage);
            }

        }

        void CustomSettingsVisible()
        {
            nudColumns.Visible =
                nudRows.Visible =
                btnGetUserImage.Visible =
                lblRow.Visible =
                lblColumns.Visible =
                (tsCustomMode.Checked);
        }

        void ToggleSwitchChecked(Guna2ToggleSwitch CheckedSwitch)
        {

            Guna2ToggleSwitch[] Toggles = { tsEasyMode, tsMediumMode,
                tsHardMode, tsCustomMode };

            foreach (Guna2ToggleSwitch Toggle in Toggles)
            {
                
                if (Toggle != CheckedSwitch)
                    Toggle.Checked = false;

            }

        }

        bool CheckMode()
        {
            return !(tsEasyMode.Checked == tsMediumMode.Checked ==
                tsHardMode.Checked == tsCustomMode.Checked);
        }

        bool OpenGameScreen()
        {

            if (CheckMode())
            {
                tc.SelectTab(1);
                return true;
            }
            else
            {
                MessageBox.Show("Select Mode Required.", "Error Mode",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        void Mes(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        Button CreateImageButton(Bitmap Image, int Row, int Column)
        {

            Button button = new Button();

            button.BackgroundImage = Image;

            button.BackgroundImageLayout = ImageLayout.Stretch;

            button.Text = null;

            button.Tag = string.Format($"{Row}_{Column}");

            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderColor = Color.Black;

            button.FlatAppearance.BorderSize = 2;

            button.Dock = DockStyle.Fill;

            return button;

        }

        Bitmap CropImage(int Row, int Column, int PartWidth, int PartHeight)
        {

            // Define Rectangle For The Current Part Of Image.
            Rectangle rectangle = new Rectangle(
                GameSettings.Image.Width / GameSettings.Columns * Column,
                GameSettings.Image.Height / GameSettings.Rows * Row,
                PartWidth, PartHeight);

            // Crop the image part.
            Bitmap PartImage = GameSettings.Image.Clone(rectangle,
                GameSettings.Image.PixelFormat);

            return PartImage;

        }

        void CreateImageButtonsList()
        {

            listImageButtons = new List<List<Button>>();

            int PartWidth = GameSettings.Image.Width / GameSettings.Columns;
            int PartHeight = GameSettings.Image.Height / GameSettings.Rows;

            //// Create a folder to save the split images
            //string outputDir = $@"C:\Puzzle Game\Images\SplitImages\Grid_{GameSettings.Rows}_{GameSettings.Columns}";

            //if (!Directory.Exists(outputDir))
            //{
            //    Directory.CreateDirectory(outputDir);
            //}

            for (int Row = 0; Row < GameSettings.Rows; Row++)
            {

                List<Button> RowList = new List<Button>();

                for (int Column = 0; Column < GameSettings.Columns; Column++)
                {

                    // Get Image Part Using 'CropImage' Function.
                    Bitmap PartImage = CropImage(Row, Column, PartWidth, PartHeight);

                    // Create Button And Insert Image Part To It Using 'CreateImageButton' Function.
                    Button ImageButton = CreateImageButton(PartImage, Row, Column);

                    // Add Column To The Current 'RowList' List.
                    RowList.Add(ImageButton);

                    //// Create Path For The Current Image Part
                    //string PathToSave = Path.Combine(outputDir,
                    //    $"Image_Part_{Row}_{Column}.jpg");

                    //PartImage.Save(PathToSave);

                    //PartImage.Dispose();

                }

                // Add Current 'RowList' List To 'listImageButtons' List.
                listImageButtons.Add(RowList);

            }

        }

        void EditPictureBoxAndtlpSize()
        {

            double width = (double)GameSettings.Image.Height / GameSettings.Image.Width;

            width = (width > 1) ? width : 1;

            width = 400 / width;

            double height = (double)GameSettings.Image.Width / GameSettings.Image.Height;

            height = (height > 1) ? height : 1;

            height = 400 / height;

            tlp.Size = new Size((int)width, (int)height);

            pbOriginalImage.Size = tlp.Size;

        }

        void EditDimensionsIntlp()
        {

            tlp.RowStyles.Clear();
            tlp.ColumnStyles.Clear();
            tlp.Controls.Clear();
            tlp.RowCount = GameSettings.Rows;
            tlp.ColumnCount = GameSettings.Columns;

            for (int i = 0; i < GameSettings.Columns; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / GameSettings.Columns));
            }

            for (int i = 0; i < GameSettings.Rows; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / GameSettings.Rows));
            }

        }

        void AddlistImageButtonsTotlp()
        {

            for (int Row = 0; Row < GameSettings.Rows; ++Row)
            {

                for (int Column = 0; Column < GameSettings.Columns; ++Column)
                {
                    tlp.Controls.Add(listImageButtons[Row][Column], Column, Row);
                }

            }

        }

        void ShuffleImageButtonsList()
        {
            // Define Random Variable.
            Random rnd = new Random();

            // Shuffle Array Randomly By Selecting 2 Elements And Swapping Them For 'n' Elements Once.
            for (int i = 0; i < listImageButtons.Count; ++i)
            {
                // Row1 & Col1 Are Repersenting One Random Element In The List.
                int Row1 = rnd.Next(0, GameSettings.Rows),
                    Col1 = rnd.Next(0, GameSettings.Columns);

                // Row2 & Col2 Are The Same For Another Random One.
                int Row2 = rnd.Next(0, GameSettings.Rows),
                    Col2 = rnd.Next(0, GameSettings.Columns);

                // Swap Both Buttons.
                Button button = listImageButtons[Row1][Col1];
                listImageButtons[Row1][Col1] = listImageButtons[Row2][Col2];
                listImageButtons[Row2][Col2] = button;

            }

        }

        void GameScreenStatus()
        {
            
            if (tsEasyMode.Checked)
                lblGSMode.Text = tsEasyMode.Tag.ToString();
            else if (tsMediumMode.Checked)
                lblGSMode.Text = tsMediumMode.Tag.ToString();
            else if (tsHardMode.Checked)
                lblGSMode.Text = tsHardMode.Tag.ToString();
            else
                lblGSMode.Text = tsCustomMode.Tag.ToString();

            lblGSRows.Text = GameSettings.Rows.ToString();
            lblGSColumns.Text = GameSettings.Columns.ToString();
            lblGSResult.ForeColor = Color.MediumSlateBlue;
            lblGSResult.Text = "Pending";
            btnGSPlayAgain.Visible = false;

        }

        void CreateGameMode()
        {
            GameScreenStatus();
            CreateImageButtonsList();
            ShuffleImageButtonsList();
            EditDimensionsIntlp();
            EditPictureBoxAndtlpSize();
            AddlistImageButtonsTotlp();
            pbOriginalImage.Image = GameSettings.Image;
            CheckWinning();
        }

        bool IsPlayerWon()
        {

            // Rows Loop.
            for (int Row = 0; Row < GameSettings.Rows; Row++)
            {
                // Columns Loop
                for (int Column = 0; Column < GameSettings.Columns; Column++)
                {
                    // Check If Current Button Is In The Right Position.
                    if (listImageButtons[Row][Column].Tag.ToString() != string.Format($"{Row}_{Column}"))
                        return false; // Not Won Yet.

                }

            }
            
            return true; // Won.

        }

        void WonGame()
        {
            // Game Win Setting.
            tlp.Enabled = false;
            MessageBox.Show("You Won!", "GG",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblGSResult.Text = "Won";
            lblGSResult.ForeColor = Color.FromArgb(253, 202, 0);
            btnGSPlayAgain.Visible = true;
        }

        void LostGame()
        {
            // Game Lose Setting.
            tlp.Enabled = false;
            MessageBox.Show("You Lost ;(", "Bad News",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblGSResult.Text = "Lost";
            lblGSResult.ForeColor = Color.OrangeRed;
            btnGSPlayAgain.Visible = true;
        }

        void CheckWinning()
        {
            // Check If Player Won The Game.
            if (IsPlayerWon())
                WonGame();
            else
                LostGame();

        }

        void ToggleSwitchClick(object sender, EventArgs e)
        {

            Guna2ToggleSwitch toggleSwitch = sender as Guna2ToggleSwitch;

            if (toggleSwitch.Checked)
                ToggleSwitchChecked((Guna2ToggleSwitch) sender);

            if (toggleSwitch == tsCustomMode)
                CustomSettingsVisible();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            if (OpenGameScreen())
            {
                SetGameSettings();
                CreateGameMode();
            }

        }

        private void btnGetUserImage_Click(object sender, EventArgs e)
        {

            ofdlg.InitialDirectory = @"C:\";
            // Need To Fix, It`s Not Support png Extension.
            ofdlg.Filter = "(*.jpg - *.png)|*.jpg";
            ofdlg.Title = "Select Image";
            ofdlg.DefaultExt = "jpg";

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                SelectedFileImage = Bitmap.FromFile(ofdlg.FileName) as Bitmap;
                ofdlg.InitialDirectory = ofdlg.InitialDirectory;
            }

        }

        private void btnGSPlayAgain_Click(object sender, EventArgs e)
        {
            tc.SelectTab(0);
        }

    }
}
