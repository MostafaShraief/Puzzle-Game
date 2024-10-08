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
        public Form1()
        {
            InitializeComponent();
        }

        stGameSettings GameSettings;

        void SetGameSettings()
        {

            if (tsEasyMode.Checked)
            {
                GameSettings = new stGameSettings(2, 2,
                    Resources.oliver_guhr_Qs3ALnjkwF4_unsplash);
            }
            else if (tsMediumMode.Checked)
            {
                GameSettings = new stGameSettings(3, 3,
                    Resources.oliver_guhr_Qs3ALnjkwF4_unsplash);
            }
            else if (tsHardMode.Checked)
            {
                GameSettings = new stGameSettings(4, 4,
                    Resources.oliver_guhr_Qs3ALnjkwF4_unsplash);
            }
            else if (tsCustomMode.Checked)
            {
                GameSettings = new stGameSettings(nudColumns.Value, nudRow.Value,
                    Resources.oliver_guhr_Qs3ALnjkwF4_unsplash);
            }

        }

        void CustomSettingsVisible()
        {
            nudColumns.Visible =
                nudRow.Visible =
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

       void OpenGameScreen()
        {

            if (CheckMode())
                tc.SelectTab(1);
            else
                MessageBox.Show("Select Mode Required.", "Error Mode",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        void ToggleSwitchClick(object sender, EventArgs e)
        {

            Guna2ToggleSwitch toggleSwitch = sender as Guna2ToggleSwitch;

            if (toggleSwitch.Checked)
            {
                ToggleSwitchChecked((Guna2ToggleSwitch) sender);
                SetGameSettings();
            }

            if (toggleSwitch == tsCustomMode)
                CustomSettingsVisible();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            OpenGameScreen();
        }

    }
}
