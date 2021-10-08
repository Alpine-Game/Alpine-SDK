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
        public static ushort MaxFPS = 165;
        public static ushort UnfocusedFPS = 30;
        public static bool Fullscreen = false;
        public static string WindowName = "Made with Alpine Game Engine";

        public static void SaveSettings()
        {
            JObject settingsWrite = new JObject(
                new JProperty("maxFps", MaxFPS),
                new JProperty("minimizedFps", UnfocusedFPS),
                new JProperty("windowX", DefaultWindowSizeX),
                new JProperty("windowY", DefaultWindowSizeY),
                new JProperty("fullscreen", Fullscreen),
                new JProperty("title", WindowName)
            );
            
            File.WriteAllText("settings.json", settingsWrite.ToString());
        }

        public static List<string> LoadSettings()
        {
            List<string> data = new List<string>();
            try
            {
                JObject settingsRead = JObject.Parse(File.ReadAllText("settings.json"));
                MaxFPS = settingsRead["maxFps"].ToObject<UInt16>();
                UnfocusedFPS = settingsRead["minimizedFps"].ToObject<UInt16>();
                WindowName = settingsRead["title"].ToObject<String>();
                
                DefaultWindowSizeX = settingsRead["windowX"].ToObject<UInt16>();
                DefaultWindowSizeY = settingsRead["windowY"].ToObject<UInt16>();
                
                data.Add(MaxFPS.ToString());
                data.Add(UnfocusedFPS.ToString());
                data.Add(WindowName);
                data.Add(DefaultWindowSizeX.ToString());
                data.Add(DefaultWindowSizeY.ToString());

            }
            catch
            {
                //Logger.LogError("Failed to load settings. Creating a new settings file.");
                SaveSettings();
            }

            return data;
        }
    }
}