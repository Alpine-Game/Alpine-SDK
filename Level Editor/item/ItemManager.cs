using System;
using System.Collections.Generic;
using System.Diagnostics;
using SFML.Graphics;

namespace Level_Editor {
    public class ItemManager {
        private RenderWindow target;

        public Dictionary<string, Item> items;

        public Item selectedItem { get; set; }
        
        public ItemManager(RenderWindow target) {
            this.target = target;
            items = new Dictionary<string, Item>();
        }

        public void addItem(Item item) {
            items.Add(item.itemName, item);
            item.create();
            Debug.WriteLine(item.itemName + "a");
            
        }

        public void disposeItem(Item item) {
            items.Remove(item.itemName);
            item.dispose();
        }

        public void update() {
            foreach (Item item in items.Values) {
                item.update();
                item.render(target);
            }
        }
    }
}