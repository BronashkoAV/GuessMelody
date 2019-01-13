using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Quiz
    {
        static public List<string> ListMusic = new List<string>();
        static public int GameDuration = 60;
        static public int MusicDuration = 10;
        static public bool RandomStart = false;
        static public string LastFolder = "";
        static public bool AllDirectories = false;

        static public void ReadMusic()
        {
            string[] music_files = Directory.GetFiles(LastFolder, "*.mp3", AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            ListMusic.Clear();
            ListMusic.AddRange(music_files);
        }

        static string regKeyName = "Software\\MyCompanyName\\GuessMelody";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", LastFolder);
                rk.SetValue("RandomStart", RandomStart);
                rk.SetValue("GameDuration", GameDuration);
                rk.SetValue("MusicDuration", MusicDuration);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    LastFolder = (string)rk.GetValue("LastFolder");
                    GameDuration = (int)rk.GetValue("GameDuration");
                    RandomStart = (bool)rk.GetValue("RandomStart");
                    MusicDuration = (int)rk.GetValue("MusicDuration");
                    AllDirectories = (bool)rk.GetValue("AllDirectories");
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
