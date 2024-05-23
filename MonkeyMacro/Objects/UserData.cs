using System.Collections.Generic;
using System.Web;

namespace MonkeyMacro
{
    internal class UserData
    {
        public string UserName { get; set; }
        public Dictionary<string, AppShortcutMapping> AppShortcutMappings { get; set; }
        public ProgramSettingInfo ProgramSettingInfo { get; set; }

        public UserData() 
        {
            AppShortcutMappings = new Dictionary<string, AppShortcutMapping>();
        }

        public void AddShortcutMapping(string appName, string shortcutName, params string[] keys)
        {
            if (!AppShortcutMappings.ContainsKey(appName))
                AppShortcutMappings[appName] = new AppShortcutMapping();

            if (!AppShortcutMappings[appName].ShortcutKeyMappings.ContainsKey(shortcutName))
                AppShortcutMappings[appName].ShortcutKeyMappings[shortcutName] = new ShortcutKeys();

            AppShortcutMappings[appName].ShortcutKeyMappings[shortcutName].Keys = keys;
        }
    }

    public class AppShortcutMapping
    {
        public Dictionary<string, ShortcutKeys> ShortcutKeyMappings { get; set; }

        public AppShortcutMapping()
        {
            ShortcutKeyMappings = new Dictionary<string, ShortcutKeys>();
        }
    }

    public class ShortcutKeys
    {
        public string[] Keys { get; set; }
    }

    internal class ProgramSettingInfo
    {
        public int Opacity { get; set; }
        public bool TopMost { get; set; }
    }

}