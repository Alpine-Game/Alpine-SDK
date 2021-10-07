using SFML.Graphics;

namespace Level_Editor.engine.util
{
    public class GameObject
    {
        public string name;
        public RenderWindow window;

        public GameObject(string name, RenderWindow window)
        {
            this.name = name;
            this.window = window;
        }

        public virtual void update()
        {
            
        }

        public virtual void render()
        {
            
        }

        public virtual void dispose()
        {
            
        }
    }
}