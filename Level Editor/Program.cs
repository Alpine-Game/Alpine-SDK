﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Form mainWindow = new MainWindow();
            Alpine alpine = new Alpine(mainWindow);

            
            alpine.init();
            alpine.create();
            mainWindow.Show();

            while (mainWindow.Visible)
            {
                System.Windows.Forms.Application.DoEvents();
                alpine.update();
                alpine.render();
            }

        }
    }
}