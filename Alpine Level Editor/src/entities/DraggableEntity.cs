using System;
using System.Collections.Generic;
using Alpine_Level_Editor.utils;
using SFML.Graphics;
using SFML.System;

namespace Alpine_Level_Editor.entities {
    public class DragableEntity : Entity {
        public DragableEntity(string name, float health, string textureFile, RenderWindow window) : base(name, health, textureFile, window) {
        }

        public DragableEntity(string name, float health, RenderWindow window) : base(name, health, window) {
        }

        public DragableEntity(string name, RenderWindow window) : base(name, window) {
        }

        public override void create() {
            base.create();
            
            foreach (GridPoint point in getHitbox()) {
                Console.WriteLine(point);
            }
        }

        public override void update() {
            
        }

        public GridPoint[] getHitbox() {
            List<GridPoint> pointList = new List<GridPoint>();
            
            Vector2u size = this.entitySprite.Texture.Size; 
            Vector2f position = this.entitySprite.Position;
            
            int iterationX = 0; 
            int iterationY = 0; 
            
            while (iterationX < (int) size.X) { //Fill x axis.
                pointList.Add(new GridPoint(iterationX, 0));

                iterationX++;
            }

            for (int i = 0; i < pointList.Count; i++) { //Fill y axis.
                pointList[i].y = iterationY;

                iterationY++;
            }

            return pointList.ToArray();
        }
    }
}