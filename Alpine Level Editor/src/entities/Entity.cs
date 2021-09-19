using System;
using SFML.Graphics;
using SFML.System;

namespace Alpine_Level_Editor.entities {
    public abstract class Entity {
        public string name { get; set; }
        public float health { get; set; }

        public Sprite entitySprite { get; set; }

        public Texture entityTexture { get; set; }
        public String textureFile { get; set; }
        public RenderWindow window { get; set; }

        public bool isDead = false;

        protected Entity(string name, float health, string textureFile, RenderWindow window) {
            this.name = name;
            this.health = health;
            this.textureFile = textureFile;
            this.window = window;
        }

        protected Entity(string name, float health, RenderWindow window) {
            this.name = name;
            this.health = health;
            this.window = window;
        }

        protected Entity(string name, RenderWindow window) {
            this.name = name;
            this.health = 100;
            this.window = window;
        }

        public virtual void create() {
            if (textureFile != null) entityTexture = new Texture(textureFile);

            //if (entityTexture != null) entitySprite = new Sprite(entityTexture); else entitySprite = new Sprite(new RectangleShape(new Vector2f(10, 10)).Texture);

            entitySprite = new Sprite(new Texture(entityTexture));
            window.Draw(entitySprite);
        }

        public abstract void update();

        public virtual void render() {
            window.Draw(entitySprite);
            Console.WriteLine("tried to render entity: " + name);
        }

        public virtual void dispose() { //Disposes any left over shit.
            entitySprite.Dispose();
        }

        public virtual void kill() { //Ultimately removes the entity from the scene.
            dispose();
            isDead = true;
        }
    }
}