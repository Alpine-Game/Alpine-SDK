using SFML.Graphics;

namespace Level_Editor.engine.scene
{
    public class SceneManager
    {
        public RenderWindow window;

        public Scene currentScene;
        
        public SceneManager(RenderWindow window, Scene firstScene)
        {
            this.window = window;
            currentScene = firstScene;
        }

        public void switchScene(Scene scene)
        {
            currentScene.unload();
            currentScene = scene;

        }

        public void drawCurrentScene()
        {
            currentScene.render();
        }

        public void updateCurrentScene()
        {
            currentScene.update();
        }

        //TODO before doing this finish coding level editor.
        public Scene loadSceneFromFile(string fileLocation)
        {
            return new Scene(window); //Load scene from file.
        }
    }
}