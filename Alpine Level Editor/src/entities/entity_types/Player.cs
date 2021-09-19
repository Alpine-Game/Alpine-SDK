using SFML.Graphics;

namespace Alpine_Level_Editor.entities.entity_types {
    public class Player : Entity {
        public Player(string name, float health, string textureFile, RenderWindow window) : base(name, health, textureFile, window) {
        }

        public override void update() {
            
        }
    }
}