// See https://aka.ms/new-console-template for more information

Dictionary<string, object> userDataDict = new Dictionary<string, object>
    {
        { "password", "1234" },
        { "userSettings", new Dictionary<string, object>
            {
                { "opacity", 85 },
                { "topMost", true }
            }
        },
        { "appsShortcutDict", new Dictionary<string, object>
            {
                { "Excel", new Dictionary<string, object> // appShortcutKeys : keyCombination<>
                    {
                        { "Copy", new string[] { "Ctrl", "C" } }, // keyname : keys[]
                        { "Paste", new string[] { "Ctrl", "V" } }
                    }
                },
                { "Word", new Dictionary<string, object>
                    {
                        { "Copy", new string[] { "Ctrl", "C" } },
                        { "Paste", new string[] { "Ctrl", "V" } },
                        { "Bold", new string[] { "Ctrl", "B" } }
                    }
                }
            }
        }
    };

void printUserSettings()
{
    if (userDataDict.ContainsKey("userSettings"))
    {
        var userSettings = userDataDict["userSettings"] as Dictionary<string, object>;

        foreach (var setting in userSettings)
        {
            Console.WriteLine($"{setting.Key} : {setting.Value}");
        }

    }
}

void printAppShortcutDict()
{
    if (userDataDict.ContainsKey("appsShortcutDict"))
    {
        var appsShortcutDict = userDataDict["appsShortcutDict"] as Dictionary<string, object>;
        foreach (var selectedAppShortcutDict in appsShortcutDict)
        {
            string selectedAppName = selectedAppShortcutDict.Key;
            Console.WriteLine(selectedAppName);

            var appShortcuts = selectedAppShortcutDict.Value as Dictionary<string, object>;
            foreach (var shortcut in appShortcuts)
            {
                Console.Write($"- {shortcut.Key} : ");
                var keyCombinationArray = shortcut.Value as string[];
                if (keyCombinationArray != null)
                {
                    for (int i = 0; i < keyCombinationArray.Length; i++)
                    {
                        Console.Write(keyCombinationArray[i]);
                        if (i < keyCombinationArray.Length - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("    Invalid key combination");
                }
            }
        }
    }
}

// 새로운 메서드
void addAppShortcut(string appName, string functionName, string[] keyCombination)
{
    if (userDataDict.ContainsKey("appsShortcutDict"))
    {
        var appsShortcutDict = userDataDict["appsShortcutDict"] as Dictionary<string, object>;

        if (!appsShortcutDict.ContainsKey(appName))
        {
            appsShortcutDict[appName] = new Dictionary<string, object>();
        }

        var appShortcuts = appsShortcutDict[appName] as Dictionary<string, object>;
        appShortcuts[functionName] = keyCombination;
    }
}

// 테스트
printUserSettings();
Console.WriteLine();
printAppShortcutDict();
Console.WriteLine();

// 새로운 단축키 추가
addAppShortcut("Excel", "Save", new string[] { "Ctrl", "S" });
addAppShortcut("PowerPoint", "New Slide", new string[] { "Ctrl", "M" });
addAppShortcut("Word", "Underline", new string[] { "Ctrl", "U" });

// 추가 후 출력
printAppShortcutDict();