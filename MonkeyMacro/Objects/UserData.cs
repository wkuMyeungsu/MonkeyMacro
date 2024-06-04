using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

        // 단축키를 추가하는 메서드
        public void AddApplicationShortcut(string applicationName, string shortcutName, KeyCombination keyCombination)
        {
            if (!AppsShortcutDict.ContainsKey(applicationName))
                AppsShortcutDict[applicationName] = new ApplicationShortcut();

            AppsShortcutDict[applicationName].ShortcutKeys[shortcutName] = keyCombination;
        }

        // 단축키를 수정하는 메서드
        public void ModifyApplicationShortcut(string applicationName, string oldShortcutName, string newShortcutName, KeyCombination newKeyCombination)
        {
            if (!AppsShortcutDict.ContainsKey(applicationName))
            {
                Debug.WriteLine($"Application '{applicationName}' does not exist. Cannot modify shortcut.");
                return;
            }

            if (!AppsShortcutDict[applicationName].ShortcutKeys.ContainsKey(oldShortcutName))
            {
                Debug.WriteLine($"Shortcut '{oldShortcutName}' for application '{applicationName}' does not exist. Cannot modify.");
                return;
            }

            // 기존 단축키 이름으로 ShortcutKeys 딕셔너리에서 항목을 찾음
            var shortcut = AppsShortcutDict[applicationName].ShortcutKeys[oldShortcutName];

            // 단축키 이름 변경
            AppsShortcutDict[applicationName].ShortcutKeys.Remove(oldShortcutName);
            AppsShortcutDict[applicationName].ShortcutKeys[newShortcutName] = newKeyCombination;
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
                        var keyCombination = new KeyCombination { Keys = keys };
                        AddApplicationShortcut(applicationName, shortcutName, keyCombination);
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
