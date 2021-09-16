using System;
using SFML.Graphics;
using SFML.Window;

namespace Alpine_Level_Editor.input {
    public class Input {
        private static bool up = false;
        private static bool down = false;
        private static bool left = false;
        private static bool right = false;

        private static bool listenerActive = false;

        public static float getHorizontal() {
            if (listenerActive) {
                if (left && right) return 0;
                if (left) return -1;
                if (right) return 1;
            }
            
            return 0;
        }
        public static float getVertical() {
            if (listenerActive) {
                if (up && down) return 0;
                if (down) return -1;
                if (up) return 1;
            }

            return 0;
        }

        public static void listenForEvents(RenderWindow window) {
            listenerActive = true;
            
            window.KeyPressed += (sender, e) => {
                switch (e.Code) {
                    case Keyboard.Key.W:
                        up = true;
                        break;
                    case Keyboard.Key.S:
                        down = true;
                        break;
                    case Keyboard.Key.A:
                        left = true;
                        break;
                    case Keyboard.Key.D:
                        right = true;
                        break;
                }
            };
            
            window.KeyReleased += (sender, e) => {
                switch (e.Code) {
                    case Keyboard.Key.W:
                        up = false;
                        break;
                    case Keyboard.Key.S:
                        down = false;
                        break;
                    case Keyboard.Key.A:
                        left = false;
                        break;
                    case Keyboard.Key.D:
                        right = false;
                        break;
                }
            };
        }
    }
}