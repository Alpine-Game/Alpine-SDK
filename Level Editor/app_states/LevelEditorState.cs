using System;
using System.Windows.Forms;
using SFML.Graphics;

namespace Level_Editor {
    public class LevelEditorState {
        private Form mainForm;

        private RenderWindow sfmlWindow;
        private SFMLBox renderer;

        private ItemManager itemManager;
        public LevelEditorState(Form mainForm) {
            this.mainForm = mainForm;

            renderer = (SFMLBox) mainForm.Controls["sfmlRenderer"];
        }

        public void create() {
            sfmlWindow = new RenderWindow(renderer.Handle);
            sfmlWindow.Closed += (sender, e) =>
            {
                System.Environment.Exit(0);
            };
            itemManager = new ItemManager(sfmlWindow);

            MainWindow mainWindow = (MainWindow)mainForm;
            mainWindow.itemManager = itemManager;
        }

        public void init() {
            
        }

        public void update() {
            sfmlWindow.DispatchEvents();
        }

        public void render() {
            sfmlWindow.Clear();
            
            itemManager.update();

            sfmlWindow.Display();
        }

        public bool getVisible()
        {
            return sfmlWindow.IsOpen;
        }
    }
}