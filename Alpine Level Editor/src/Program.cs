using System;
using SFML.Graphics;
using SFML.Window;

namespace Alpine_Level_Editor {
    class Program {
        public static Alpine alpine;
        static void Main(string[] args) {
             alpine = new Alpine();

            alpine.init(); //Create window and shit.
            alpine.create(); //Create sprites and shit.

            while (alpine.isRunning()) {
                alpine.update(); //Update shit.
                alpine.render(); //Render shit.
            }
        }
    }
}