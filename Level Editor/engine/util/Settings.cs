using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Level_Editor.engine.util
{
    public class Settings
    {
        public static ushort DefaultWindowSizeX = 1280;
        public static ushort DefaultWindowSizeY = 720;
        public static bool UnlimitedFramerate = false;
        public static ushort MaxFPS = 165;
        public static ushort UnfocusedFPS = 30;
        public static bool Fullscreen = false;
        public static string ProjectName = "Alpine Game";
        public static string WindowName = "Made with Alpine Game Engine";
        public static bool FixedAspectRatio = true;

        public static void SaveSettings()
        {
            JObject settingsWrite = new JObject(
                new JProperty("projectName", ProjectName),
                new JProperty("maxFps", MaxFPS),
                new JProperty("windowX", DefaultWindowSizeX),
                new JProperty("windowY", DefaultWindowSizeY),
                new JProperty("windowTitle", WindowName)
            );
            
            File.WriteAllText(Program.projectPath, settingsWrite.ToString());
        }
        
        public static void SaveSettings(string path)
        {
            JObject settingsWrite = new JObject(
                new JProperty("projectName", ProjectName),
                new JProperty("maxFps", MaxFPS),
                new JProperty("windowX", DefaultWindowSizeX),
                new JProperty("windowY", DefaultWindowSizeY),
                new JProperty("windowTitle", WindowName)
            );
            
            File.WriteAllText(path, settingsWrite.ToString());
        }

        public static void LoadSettings(string path)
        {
            Program.projectPath = path;
            try
            {
                JObject settingsRead = JObject.Parse(File.ReadAllText(path));

                ProjectName = settingsRead["projectName"].ToObject<string>();
                MaxFPS = settingsRead["maxFps"].ToObject<UInt16>();
                WindowName = settingsRead["windowTitle"].ToObject<string>();
                DefaultWindowSizeX = settingsRead["windowX"].ToObject<UInt16>();
                DefaultWindowSizeY = settingsRead["windowY"].ToObject<UInt16>();

            }
            catch
            {
                //Logger.LogError("Failed to load settings. Creating a new settings file.");
                SaveSettings();
            }
        }
    }
}