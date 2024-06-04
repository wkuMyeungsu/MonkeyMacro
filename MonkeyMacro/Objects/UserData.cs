using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MonkeyMacro
{
    public class UserData
    {
        public string UserName { get; set; }
        public Dictionary<string, ApplicationShortcut> AppsShortcutDict { get; set; }
        public UserSettings UserSettings { get; set; }

        public UserData()
        {
            AppsShortcutDict = new Dictionary<string, ApplicationShortcut>();
        }

        public void AddApplicationShortcut(string applicationName, string shortcutName, params string[] keys)
        {
            if (!AppsShortcutDict.ContainsKey(applicationName))
                AppsShortcutDict[applicationName] = new ApplicationShortcut();

            if (!AppsShortcutDict[applicationName].ShortcutKeys.ContainsKey(shortcutName))
                AppsShortcutDict[applicationName].ShortcutKeys[shortcutName] = new KeyCombination();

            AppsShortcutDict[applicationName].ShortcutKeys[shortcutName].Keys = keys;
        }

        // 데이터를 로드하는 메서드
        public void LoadFromFirebaseController(Dictionary<string, object> data)
        {
            var appsShortcuts = (Dictionary<string, object>)data["appsShortcutDict"];
            foreach (var app in appsShortcuts)
            {
                var applicationName = app.Key;
                var shortcuts = (Dictionary<string, object>)app.Value;
                foreach (var shortcut in shortcuts)
                {
                    string shortcutName = shortcut.Key;
                    var keysObject = shortcut.Value as List<object>;
                    string[] keys = keysObject?.Cast<string>().ToArray(); // 안전한 캐스팅과 변환 수행

                    if (keys != null)
                    {
                        AddApplicationShortcut(applicationName, shortcutName, keys);
                    }
                    else
                    {
                        Debug.WriteLine("Failed to cast shortcut keys to string array for " + shortcutName);
                    }
                }
            }

            var settings = (Dictionary<string, object>)data["userSettings"];
            UserSettings = new UserSettings
            {
                Opacity = Convert.ToDouble(settings["opacity"]),
                TopMost = Convert.ToBoolean(settings["topMost"]),
                UseTrayMinimize = Convert.ToBoolean(settings["useTrayMinimize"])
            };
        }

    }

    public class ApplicationShortcut
    {
        public Dictionary<string, KeyCombination> ShortcutKeys { get; set; }

        public ApplicationShortcut()
        {
            ShortcutKeys = new Dictionary<string, KeyCombination>();
        }
    }

    public class KeyCombination
    {
        public string[] Keys { get; set; }
    }

    public class UserSettings
    {
        public double Opacity { get; set; }
        public bool TopMost { get; set; }
        public bool UseTrayMinimize { get; set; }
    }
}
