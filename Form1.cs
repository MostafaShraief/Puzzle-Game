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
using System.Resources;
using MaterialSkin;


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

        public class ButtonPosition
        {
            public (int Row, int Col) OriginalPosition { get; set; }
            public (int Row, int Col) CurrentPosition { get; set; }

            public ButtonPosition(int originalRow, int originalCol, int currentRow, int currentCol)
            {
                OriginalPosition = (originalRow, originalCol);
                CurrentPosition = (currentRow, currentCol);
            }
        }

        List<List<Button>> listImageButtons;

        stGameSettings GameSettings;

        Bitmap SelectedFileImage;

        Button BlankButton;

        public int TimeTicksCounter;

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

        void SwitchSelectedButton(object sender, EventArgs e)
        {

            Button SelectedButton = sender as Button;

            EnableOrDisableSorroundBlankButton(false); // Disable.

            // Swap 'SelectedButton' And 'BlankButton'.
            SwapButtons(SelectedButton, BlankButton);

            // Refresh the UI to ensure the changes are shown
            SelectedButton.Refresh();
            BlankButton.Refresh();

            // Update Blank Button.
            BlankButton = SelectedButton;

            EnableOrDisableSorroundBlankButton(true); // Enable.
  
            CheckWinning();

        }

        Button CreateImageButton(Bitmap Image, int Row, int Column)
        {

            Button button = new Button();

            button.BackgroundImage = Image;

            button.BackgroundImageLayout = ImageLayout.Stretch;

            button.BackColor = Color.Black;

            button.Text = null;

            button.Tag = new ButtonPosition(Row, Column, Row, Column); // Org, Org, Cur, Cur

            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderColor = Color.Black;

            button.FlatAppearance.BorderSize = 2;

            button.Dock = DockStyle.Fill;

            button.Enabled = false;

            button.Click += new EventHandler(SwitchSelectedButton);

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
            tlp.Enabled = true;
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

        void EnableOrDisableSorroundBlankButton(bool Enable)
        {

            var PosBlank = BlankButton.Tag as ButtonPosition;

            // Get Row And Column Index.
            int Row = PosBlank.CurrentPosition.Row;
            int Col = PosBlank.CurrentPosition.Col;

            if (Row > 0)
                listImageButtons[Row - 1][Col].Enabled = Enable; // Up
            if (Col > 0)
                listImageButtons[Row][Col - 1].Enabled = Enable; // Left
            if (Row < GameSettings.Rows - 1)
                listImageButtons[Row + 1][Col].Enabled = Enable; // Down
            if (Col < GameSettings.Columns - 1)
                listImageButtons[Row][Col + 1].Enabled = Enable; // Right

        }

        void SelectAndSetBlankButton()
        {

            Random rdm = new Random();

            // Get Random Row And Column.
            int Row = rdm.Next(0, GameSettings.Rows);
            int Col = rdm.Next(0, GameSettings.Columns);

            // Assign Current Buttons TO 'BlankButton'.
            BlankButton = listImageButtons[Row][Col];

            // Enable Buttons That Sorround Blank Button.
            EnableOrDisableSorroundBlankButton(true);

            // Change Background Image Of 'BlankButton'.
            BlankButton.BackgroundImage = null;

        }

        void SwapButtons(Button btn1, Button btn2)
        {

            if (btn1 == btn2)
                return;

            // Get Position Of Both Buttons.
            var Pos1 = btn1.Tag as ButtonPosition;
            var Pos2 = btn2.Tag as ButtonPosition;

            // Swap Current Posistions Of Both.
            var TempPos = Pos1.OriginalPosition;
            Pos1.OriginalPosition = Pos2.OriginalPosition;
            Pos2.OriginalPosition = TempPos;

            // Swap Both Buttons.
            var image = btn1.BackgroundImage;
            btn1.BackgroundImage = btn2.BackgroundImage;
            btn2.BackgroundImage = image;

            // Refresh UI.
            btn1.Refresh();
            btn2.Refresh();

        }

        void ShuffleImageButtonsList()
        {
            // Define Random Variable.
            Random rnd = new Random();

            // Shuffle Array Randomly By Selecting 2 Elements And Swapping Them For 'n' Elements Once.
            for (int i = 0; i < tlp.Controls.Count; ++i)
            {
                // Row1 & Col1 Are Repersenting One Random Element In The List.
                int Row1 = rnd.Next(0, GameSettings.Rows),
                    Col1 = rnd.Next(0, GameSettings.Columns);

                // Row2 & Col2 Are The Same For Another Random One.
                int Row2 = rnd.Next(0, GameSettings.Rows),
                    Col2 = rnd.Next(0, GameSettings.Columns);

                SwapButtons(listImageButtons[Row1][Col1],
                    listImageButtons[Row2][Col2]);

            }

        }

        void GameScreenStatus()
        {
            
            if (tsEasyMode.Checked) // Easy Mode.
                lblGSMode.Text = tsEasyMode.Tag.ToString();
            else if (tsMediumMode.Checked) // Medium Mode.
                lblGSMode.Text = tsMediumMode.Tag.ToString();
            else if (tsHardMode.Checked) // Hard Mode.
                lblGSMode.Text = tsHardMode.Tag.ToString();
            else // Custom Mode.
                lblGSMode.Text = tsCustomMode.Tag.ToString();

            // Update Rows And Columns Status.
            lblGSRows.Text = GameSettings.Rows.ToString();
            lblGSColumns.Text = GameSettings.Columns.ToString();
            // Update Result Status.
            lblGSResult.ForeColor = Color.MediumSlateBlue;
            lblGSResult.Text = "Pending";
            // Hide Play Again Button.
            btnGSPlayAgain.Visible = false;

        }

        void RunTimer()
        {
            tmr.Interval = 1;
            tmr.Enabled = true;
            TimeTicksCounter = 0;
            tmr_Tick(tmr, EventArgs.Empty);
        }

        void CreateGameMode()
        {
            GameScreenStatus();
            CreateImageButtonsList();
            EditDimensionsIntlp();
            EditPictureBoxAndtlpSize();
            AddlistImageButtonsTotlp();
            ShuffleImageButtonsList();
            SelectAndSetBlankButton();
            btnGSShuffle.Visible = true;
            pbOriginalImage.Image = GameSettings.Image;
            RunTimer();
            CheckWinning();
        }

        bool IsPlayerWon()
        {

            // Loop Through Each Control In 'tlp' And Check Its Position.
            foreach (Button item in tlp.Controls)
            {

                var Pos = item.Tag as ButtonPosition;

                // Current Should Be Equal To Original For Winning.
                if (Pos.CurrentPosition != Pos.OriginalPosition)
                    return false; // Lost

            }

            return true; // Won.

        }

        void StopTimer()
        {
            tmr.Enabled = false;
        }

        void WonGame()
        {
            // Game Win Setting.
            tlp.Enabled = false;
            lblGSResult.Text = "Won";
            lblGSResult.ForeColor = Color.FromArgb(253, 202, 0);
            btnGSPlayAgain.Visible = true;
            btnGSShuffle.Visible = false;
            StopTimer();
            MessageBox.Show("You Won!", "GG",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 'LostGame' Function For Upcoming Update.
        void LostGame()
        {
            // Game Lose Setting.
            tlp.Enabled = false;
            lblGSResult.Text = "Lost";
            lblGSResult.ForeColor = Color.OrangeRed;
            btnGSPlayAgain.Visible = true;
            StopTimer();
            MessageBox.Show("You Lost ;(", "Bad News",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void CheckWinning()
        {
            // Check If Player Won The Game.
            if (IsPlayerWon())
                WonGame();

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
            ofdlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
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
            CreateGameMode();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            ++TimeTicksCounter;

            int Seconds = TimeTicksCounter / 60 % 60;
            int Minutes = TimeTicksCounter / 3600 % 60;

            lblGSTime.Text = string.Format("{0}:{1:D2}", Minutes, Seconds);

        }

        void UpdateBlankButtonPosition()
        {

            foreach (var itemrow in listImageButtons)
            {

                foreach (var itemcol in itemrow)
                {

                    if (itemcol.BackgroundImage == null)
                    {
                        BlankButton = itemcol;
                        break;
                    }

                }

            }

        }

        private void btnGSShuffle_Click(object sender, EventArgs e)
        {
            EnableOrDisableSorroundBlankButton(false);
            ShuffleImageButtonsList();
            UpdateBlankButtonPosition();
            EnableOrDisableSorroundBlankButton(true);
            CheckWinning();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tc.SelectTab(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string teleramurl = "https://t.me/Mostafa_Shraief";
            System.Diagnostics.Process.Start(teleramurl);
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            string githuburl = "https://github.com/MostafaShraief";
            System.Diagnostics.Process.Start(githuburl);
        }
    }
}
