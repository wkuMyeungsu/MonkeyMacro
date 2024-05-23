using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyMacro
{
    // 단축키 클래스 정의
    public class ShortCutKey
    {
        public string KeyName { get; set; }
        public List<string> Keys { get; set; }

        public ShortCutKey(string macroName, List<string> keys)
        {
            KeyName = macroName;
            Keys = keys;
        }
    }

    // UserData 클래스 정의
    public class UserData
    {
        // 계정
        private string UserName { get; set; }
        private string Password { get; set; }

        // 프로그램 설정 값
        private int ProgramOpacity { get; set; }
        private bool ProgramTopMost { get; set; }

        // 키 목록
        private Dictionary<string, List<ShortCutKey>> ProgramShortCutKeys { get; set; }

        // 생성자
        public UserData()
        {
            // 기본값 설정
            UserName = string.Empty;
            Password = string.Empty;
            ProgramOpacity = 100;
            ProgramTopMost = false;
            ProgramShortCutKeys = new Dictionary<string, List<ShortCutKey>>();
        }

        // 프로그램에 단축키 추가
        public void AddShortCutKey(string programName, string keyName, List<string> keys)
        {
            if (!ProgramShortCutKeys.ContainsKey(programName))
            {
                ProgramShortCutKeys[programName] = new List<ShortCutKey>();
            }

            ProgramShortCutKeys[programName].Add(new ShortCutKey(keyName, keys));
        }

        public void PrintMacroKey
    }
}
