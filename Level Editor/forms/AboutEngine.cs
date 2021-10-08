using System.Drawing;
using System.Windows.Forms;

namespace Level_Editor
{
    public partial class AboutEngine : Form
    {
        public AboutEngine()
        {
            InitializeComponent();
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "res/icon.png";
            pb1.Location = new Point(40, -60);
            pb1.Size = new Size(500, 500);
            Controls.Add(pb1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/Alpine-Game/Alpine-Level-Editor");
        }
    }
}