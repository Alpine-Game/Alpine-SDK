using System;
using System.Linq;
using Level_Editor.engine.scene;
using Level_Editor.engine.util;
using SFML.Graphics;
using SFML.Window;

namespace Level_Editor
{
    public class GameState
    {
        /*
         * UNIMPLEMENTED!!!!
         * Future plans include running the level editor along side the game for modding purposes!
         */

        private RenderWindow window;
        private VideoMode mode;

        enum LoadingState { LOADING, RUNNING, QUITTING }
        enum PostLoadAction { ENTER_TITLE_SCREEN, LOAD_LEVEL }

        private LoadingState loadingState;
        private PostLoadAction postLoadAction;

        private string loadLevelPath = ""; //This is used if postLoadAction is set to LOAD_LEVEL.

        private SceneManager sceneManager;

        public GameState(params String[] args)
        {
            loadingState = LoadingState.LOADING; //The game is loading.

            if (args.Contains("-L"))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].Equals("-L"))
                    {
                        postLoadAction = PostLoadAction.LOAD_LEVEL;
                        loadLevelPath = args[i + 1];
                        break;
                    }
                }
            }
            else
            {
                postLoadAction = PostLoadAction.ENTER_TITLE_SCREEN;
            }
            
            Settings.LoadSettings();

            mode = new VideoMode(Settings.DefaultWindowSizeX, Settings.DefaultWindowSizeY);
            window = new RenderWindow(mode, Settings.WindowName);
            
            window.SetIcon(256, 256, new Image("res/icon.png").Pixels);

            init(); //Load all the shit!!
            
            loadingState = LoadingState.RUNNING;

            while (loadingState == LoadingState.RUNNING)
            {
                update();
                render();
            }
        }

        public void init()
        { //Preload operations.
            sceneManager = new SceneManager(window, new Scene(window));
            events();
        }

        public void create()
        { //Create sprites to draw.
            
        }

        public void update()
        {
            window.DispatchEvents();
            sceneManager.updateCurrentScene();
        }

        public void events()
        {
            window.Closed += (sender, e) =>
            {
                window.Close();
                loadingState = LoadingState.QUITTING;
            };
        }

        public void render()
        {
            window.Clear();
            sceneManager.drawCurrentScene();
            window.Display();
        }
    }
}