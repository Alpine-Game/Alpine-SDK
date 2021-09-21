using System;
using System.Collections.Generic;

namespace Alpine_Level_Editor.utils.entity_utils {
    public class EntityData {
        public String name { get; set; }
        public String texLoc { get; set; }
        public float health { get; set; }
        public List<String> customData { get; set; }
    }
}