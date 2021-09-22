using System;
using System.Collections.Generic;
using Alpine_Level_Editor.input;
using Alpine_Level_Editor.ui;
using Alpine_Level_Editor.utils;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Alpine_Level_Editor.entities {
    public class DragableEntity : Entity {
        private bool isClicked = false;

        private LevelEditorUI gui;
        public DragableEntity(string name, float health, string textureFile, RenderWindow window, LevelEditorUI gui) : base(name, health, textureFile, window) {
            this.gui = gui;
        }

        public DragableEntity(string name, float health, RenderWindow window) : base(name, health, window) {
        }

        public DragableEntity(string name, RenderWindow window) : base(name, window) {
        }

        public override void update() {
            Vector2f mousePosition = new Vector2f(0, 0);
            mousePosition = window.MapPixelToCoords(new Vector2i(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y));

            mousePosition.X = mousePosition.X + window.GetView().Center.X - (window.GetView().Size.X / 2) + 1;
            mousePosition.Y = mousePosition.Y + window.GetView().Center.Y - (window.GetView().Size.Y / 2);
            
            FloatRect mousePos = new FloatRect();

            mousePos.Left = mousePosition.X;
            mousePos.Top = mousePosition.Y;
            mousePos.Width = 4;
            mousePos.Height = 4;
            
            if (Mouse.IsButtonPressed(Mouse.Button.Left)) {
                if (mousePos.Intersects(getHitbox())) {
                    isClicked = true;
                }
            }
            
            window.MouseButtonReleased += (sender, e) => {
                if (e.Button == Mouse.Button.Left) {
                    isClicked = false;
                }
            };

            if (isClicked&& gui.getGUI().GetWidgetBelowMouseCursor((int) mousePosition.X, (int) mousePosition.Y) == null) {
                entitySprite.Position = new Vector2f(mousePosition.X, mousePosition.Y);
            }
            
            //Console.WriteLine(mouseX + "," + mouseY);
            //Console.WriteLine(getHitbox().Contains(mouseX, mouseY));
        }

        public FloatRect getHitbox() {
            return entitySprite.GetGlobalBounds();
        }
        
    }
}