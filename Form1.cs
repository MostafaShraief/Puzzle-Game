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

        List<List<Button>> ImageButtonsList;

        stGameSettings GameSettings;

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
                GameSettings = new stGameSettings(nudRows.Value, nudColumns.Value,
                    Resources.Cat);
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

        Button CreateImageButton(Bitmap Image)
        {

            Button button = new Button();

            button.BackgroundImage = Image;

            button.BackgroundImageLayout = ImageLayout.Stretch;

            button.Text = "";

            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderColor = Color.Black;

            button.FlatAppearance.BorderSize = 5;

            return button;

        }

        void CreatePictureBoxesList()
        {

            ImageButtonsList = new List<List<Button>>();

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

                    // Define Rectangle For The Current Part Of Image
                    Rectangle rectangle = new Rectangle(
                        GameSettings.Image.Width / GameSettings.Columns * Column,
                        GameSettings.Image.Height / GameSettings.Rows * Row,
                        PartWidth, PartHeight);

                    // Crop the image part
                    Bitmap PartImage = GameSettings.Image.Clone(rectangle,
                        GameSettings.Image.PixelFormat);

                    Button ImageButton = CreateImageButton(PartImage);

                    RowList.Add(ImageButton);

                    //// Create Path For The Current Image Part
                    //string PathToSave = Path.Combine(outputDir,
                    //    $"Image_Part_{Row}_{Column}.jpg");

                    //PartImage.Save(PathToSave);

                    //PartImage.Dispose();

                }

                ImageButtonsList.Add(RowList);

            }

        }

        void CreateGameMode()
        {
            CreatePictureBoxesList();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

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

    }
}
