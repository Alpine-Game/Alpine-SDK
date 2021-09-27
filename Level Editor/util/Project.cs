using System.Collections.Generic;

namespace Level_Editor {
    public class Project {
        public string name;
        public string location;
        public string music;

        public List<Item> items;

        public Project(string name, string location, string music, List<Item> items) {
            this.name = name;
            this.location = location;
            this.music = music;
            this.items = items;
        }

        public void saveToFile() {
            
        }
    }
}