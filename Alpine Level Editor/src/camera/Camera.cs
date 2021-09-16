using System;
using Alpine_Level_Editor.input;
using SFML.Graphics;
using SFML.System;

namespace Alpine_Level_Editor.camera {
    public class Camera {
        private View view;

        public Camera(View view) {
            this.view = view;
        }

        public void update() {
            float horiz = Input.getHorizontal();
            float verti = Input.getVertical();

            float velocityX = 0f;
            float velocityY = 0f;

            float speed = 160;

            if (horiz != 0) {
                velocityX = view.Center.X + horiz * speed * Program.alpine.deltaTime;
            }
            else {
                velocityX = view.Center.X;
            }
            
            if (verti != 0) {
                velocityY = view.Center.Y + verti * speed * Program.alpine.deltaTime;
            }
            else {
                velocityY = view.Center.Y;
            }

            view.Center = new Vector2f(velocityX, velocityY);
            
            Console.WriteLine(view.Center.X);
        }
    }
}