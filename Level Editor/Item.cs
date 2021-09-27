using SFML.Graphics;

namespace Level_Editor {
    public class Item {
        public enum ItemType { ENTITY, WORLD, TILEMAP }
        
        public ItemType itemType;
        public Sprite itemSprite;
        public Texture itemTexture;
        public string texturePath;
        
        public string itemName { get; set; }

        public Item(string name, string texturePath, ItemType itemType) {
            this.itemName = name;
            this.itemType = itemType;
            this.texturePath = texturePath;
            this.itemType = itemType;
        }

        public void create() {
            itemTexture = new Texture(texturePath);
            itemSprite = new Sprite(itemTexture);
        }

        public void update() {
            
        }

        public void render(RenderWindow target) {
            target.Draw(itemSprite);
        }

        public void dispose() {
            itemSprite.Dispose();
            itemTexture.Dispose();
        }
    }
}