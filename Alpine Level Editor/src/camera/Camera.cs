using System;
using Alpine_Level_Editor.input;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Alpine_Level_Editor.camera {
    public class Camera {
        private View view;
        private float cameraSpeed;

        public Camera(View view, float cameraSpeed) {
            this.view = view;
            this.cameraSpeed = cameraSpeed;
        }

        public void update() {
            float horiz = Input.getHorizontal();
            float verti = Input.getVertical();

            float velocityX = 0f;
            float velocityY = 0f;

            float speed = cameraSpeed;

            float speedMultiplier = 1f;

            if (Input.getShift()) {
                speedMultiplier = 5f;
            }
            else {
                speedMultiplier = 1f;
            }

            if (horiz != 0) {
                velocityX = view.Center.X + speedMultiplier * (horiz * speed * Program.alpine.deltaTime);
            }
            else {
                velocityX = view.Center.X;
            }
            
            if (verti != 0) {
                velocityY = view.Center.Y + speedMultiplier * (verti * speed * Program.alpine.deltaTime);
            }
            else {
                velocityY = view.Center.Y;
            }

            view.Center = new Vector2f(velocityX, velocityY);
        }
    }
}