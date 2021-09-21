using Alpine_Level_Editor.camera;
using Alpine_Level_Editor.entities;
using Alpine_Level_Editor.input;
using Alpine_Level_Editor.ui;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using TGUI;

namespace Alpine_Level_Editor {
    public class Alpine {
        public RenderWindow window;
        private VideoMode mode;

        public EntityManager entityManager;

        private AlpineUI gui;
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
            mode = new VideoMode(1280, 720);                    //Build the
            window  = new RenderWindow(mode, "Alpine Level Editor");    //window :D
            
            viewport = new View(new FloatRect(new Vector2f(0, 0), new Vector2f(1280, 720))); //Add the
            ui = new View(new FloatRect(new Vector2f(0, 0), new Vector2f(1280, 720)));       //cameras.
            
            window.SetView(viewport); //Set the *viewport* to the viewport camera.
            
            camera = new Camera(viewport, 200f); //Use the camera class with the viewport for wasd movement.
            
            entityManager = new EntityManager(this);
            
            gui = new LevelEditorUI(window, entityManager); //Add the gui.
        }

        public void create() {
            entityManager.create();
            sprite = new Sprite(new Texture("res/yes.png"));
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

            //window.Draw(sprite);
            entityManager.update(window);
            gui.update();
            

            window.Display();
        }
    }
}