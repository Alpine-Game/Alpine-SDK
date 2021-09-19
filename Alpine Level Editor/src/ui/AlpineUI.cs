using System;
using System.Collections.Generic;
using SFML.Graphics;
using TGUI;

namespace Alpine_Level_Editor.ui {
    public abstract class AlpineUI {
        private Gui gui;
        public RenderWindow renderWindow;

        public AlpineUI(RenderWindow window) {
            this.gui = new Gui(window);

            this.renderWindow = renderWindow;
        }

        public AlpineUI(RenderWindow window, String uiFile) {
            this.gui = new Gui(window);
            this.gui.LoadWidgetsFromFile(uiFile);

            this.renderWindow = renderWindow;
        }

        public AlpineUI(Gui gui) {
            this.gui = gui;
        }

        public virtual void update() {
            this.gui.Draw();

            render();
        }

        public abstract void render();

        public Gui getGUI() {
            return this.gui;
        }

        public Dictionary<String, int> getWidgets() {
            Dictionary<String, int> widgets = new Dictionary<string, int>();

            for (int i = 0; i < gui.Widgets.Count; i++) {
                widgets.Add(gui.Widgets[i].Name, i);
            }

            return widgets;
        }

        public Widget getWidget(String entName) {
            return getGUI().Widgets[getWidgets()[entName]];
        }
    }
}