using System;
using System.Collections.Generic;
using TGUI;

namespace Alpine_Level_Editor.utils {
    public class AlpineCollections {
        public static Dictionary<string, int> getWidgetsFromPanel(Panel panel) {
            Dictionary<String, int> list = new Dictionary<String, int>();

            for (int i = 0; i < panel.Widgets.Count; i++) {
                list.Add(panel.Widgets[i].Name, i);
            }

            return list;
        }
    }
}