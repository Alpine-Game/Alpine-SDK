using System;

namespace Level_Editor {
    public class Paths {
        public static String getImage(string imageName) {
            return String.Format("res/images/{0}", imageName);
        }
    }
}