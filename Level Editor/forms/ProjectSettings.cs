using System;
using System.Windows.Forms;
using System.IO;
using Level_Editor.engine.util;
using Newtonsoft.Json.Linq;

namespace Level_Editor
{
    public partial class ProjectSettings : Form
    {
        public ProjectSettings()
        {
            InitializeComponent();
            JObject projectRead = JObject.Parse(File.ReadAllText(Program.projectPath));
            projectName.Text = projectRead["projectName"].ToObject<string>();
            textBox1.Text = projectRead["maxFps"].ToObject<string>();
            windowName.Text = projectRead["windowTitle"].ToObject<string>();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Settings.ProjectName = projectName.Text;
            Settings.MaxFPS = UInt16.Parse(textBox1.Text); //textBox1 because renaming it breaks everything... fml
            Settings.WindowName = windowName.Text;
            Settings.SaveSettings(); //for some reason i forgot this and it caused me a headache. Welcome to programming!
            
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}