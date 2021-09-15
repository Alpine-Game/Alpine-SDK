using SFML.Graphics;
using SFML.Window;
using TGUI;

namespace Alpine_Level_Editor {
    public class Alpine {
        private RenderWindow window;
        private VideoMode mode;

        private Gui gui;
        private Sprite sprite;

        public Alpine() {
        }

        public bool isRunning() {
            return window.IsOpen;
        }

        public void init() { 
            mode = new VideoMode(1280, 720);
            window  = new RenderWindow(mode, "Alpine Level Editor");
            gui = new Gui(window);
        }

        public void create() {
            gui.LoadWidgetsFromFile("res/fuck.txt");
        }

        public void update() {
            events();
        }

        public void events() {
            window.DispatchEvents();
            
            window.Closed += (sender, e) => {
                ((Window) sender).Close();
            };
        }

        public void render() {
            window.Clear();
            
            gui.Draw();
            
            window.Display();
        }
    }
}