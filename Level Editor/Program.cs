﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor {
    static class Program
    {
        public static string projectPath = "ERROR";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args) {
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if (arg == "-editor")
                    { 
                        Console.WriteLine("Starting Alpine in level editor mode.");
                
                        Form mainWindow = new MainWindow();
                        LevelEditorState alpine = new LevelEditorState(mainWindow);

            
                        alpine.init();
                        alpine.create();
                        mainWindow.Show();

                        while (mainWindow.Visible)
                        {
                            Application.DoEvents();
                            alpine.update();
                            alpine.render();
                        }
                    }
                }
            }
            else
            {
                GameState gameState = new GameState(args:"");
            }
        }
    }
}