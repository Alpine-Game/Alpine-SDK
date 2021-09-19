using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Window;

namespace Alpine_Level_Editor.input {
    public class Input {
        private static bool up = false;
        private static bool down = false;
        private static bool left = false;
        private static bool right = false;
        private static bool shift = false;

        private static bool listenerActive = false;
        
        private static List<Keyboard.Key> keysHeld = new List<Keyboard.Key>();

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
                if (down) return 1;
                if (up) return -1;
            }

            return 0;
        }

        public static bool getKey(Keyboard.Key key) {
            bool isHeld = false;

            foreach (Keyboard.Key heldKey in keysHeld) {
                if (heldKey == key) isHeld = true;
                break;
            }

            return isHeld;
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
                    case Keyboard.Key.LShift:
                    case Keyboard.Key.RShift:
                        shift = true;
                        break;
                }
                
                try {
                    if (keysHeld.Contains(e.Code)) keysHeld.Add(e.Code);
                }
                catch (Exception exception) {
                    Console.WriteLine("Had trouble with adding this key.");
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
                    case Keyboard.Key.LShift:
                    case Keyboard.Key.RShift:
                        shift = false;
                        break;
                }

                try {
                    keysHeld.RemoveAll(item => item == e.Code);
                }
                catch (Exception exception) {
                    Console.WriteLine("Had trouble with removing this key.");
                }
            };
        }
        
        public static bool getShift() {
            return shift;
        }
    }
}