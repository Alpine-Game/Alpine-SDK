using System;
using System.Windows.Forms;

using Level_Editor.engine.util;

namespace Level_Editor
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            Settings.LoadSettings();
            WindowText.Text = Settings.WindowName;
            resX.Text = Settings.DefaultWindowSizeX.ToString();
            resY.Text = Settings.DefaultWindowSizeY.ToString();
            Fullscreen.Checked = Settings.Fullscreen;
        }

        private void resX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.DefaultWindowSizeX = UInt16.Parse(resX.Text);
            }
            catch (Exception exception)
            {
                resX.Text = "0";
            }
        }

        private void resY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.DefaultWindowSizeY = UInt16.Parse(resY.Text);
            }
            catch (Exception exception)
            {
                resY.Text = "0";
            }
        }

        private void Fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Fullscreen = Fullscreen.Checked;
        }

        private void WindowText_TextChanged(object sender, EventArgs e)
        {
            Settings.WindowName = WindowText.Text;
        }

        private void SaveAndExit_Click(object sender, EventArgs e)
        {
            Settings.SaveSettings();
        }
    }
}