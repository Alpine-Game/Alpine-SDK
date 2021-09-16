using Alpine_Level_Editor.camera;
using Alpine_Level_Editor.input;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using TGUI;

namespace Alpine_Level_Editor {
    public class Alpine {
        private RenderWindow window;
        private VideoMode mode;

        private Gui gui;
        private View viewport;
        private View ui;
        private Sprite sprite;
        private Camera camera;
        
        private Clock framerate_clock = new Clock();
        public Clock deltaClock = new Clock();
        public float deltaTime;
        private float framerate_lastTime = 0;
        public float fps;

        public Alpine() {
        }

        public bool isRunning() {
            return window.IsOpen;
        }

        public void init() { 
            mode = new VideoMode(1280, 720);
            window  = new RenderWindow(mode, "Alpine Level Editor");
            
            viewport = new View(new Vector2f(0, 0), new Vector2f(1280, 720));
            ui = new View(new Vector2f(0, 0), new Vector2f(1280, 720));
            
            window.SetView(viewport);
            
            camera = new Camera(viewport);

            gui = new Gui(window);
        }

        public void create() {
            sprite = new Sprite(new Texture("res/yes.png"));
            
            gui.LoadWidgetsFromFile("res/fuck.txt");
        }

        public void update() {
            events();
            
            //Thanks RooX!
            #region fpsshit
                deltaTime = deltaClock.Restart().AsSeconds();
                
                float currentTime = framerate_clock.Restart().AsSeconds();
                fps = 1 / currentTime;
                framerate_lastTime = currentTime;
                #endregion
                
            camera.update();
        }

        public void events() {
            Input.listenForEvents(window);
            
            window.DispatchEvents();
            
            window.Closed += (sender, e) => {
                ((Window) sender).Close();
            };
        }

        public void render() {
            window.Clear();
            
            window.SetView(viewport);
            
            window.Draw(sprite);
            gui.Draw();

            window.Display();
        }
    }
}