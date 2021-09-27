﻿using System;
using System.Windows.Forms;
using SFML.Graphics;

namespace Level_Editor {
    public class Alpine {
        private Form mainForm;

        private RenderWindow sfmlWindow;
        private SFMLBox renderer;

        private ItemManager itemManager;
        public Alpine(Form mainForm) {
            this.mainForm = mainForm;

            renderer = (SFMLBox) mainForm.Controls["sfmlRenderer"];
        }

        public void create() {
            sfmlWindow = new RenderWindow(renderer.Handle);
            itemManager = new ItemManager(sfmlWindow);

            MainWindow mainWindow = (MainWindow)mainForm;
            mainWindow.itemManager = itemManager;
        }

        public void init() {
            
        }

        public void update() {
            sfmlWindow.DispatchEvents();
        }

        public void render() {
            sfmlWindow.Clear();
            
            itemManager.update();

            sfmlWindow.Display();
        }

        public bool getVisible()
        {
            return sfmlWindow.IsOpen;
        }
    }
}