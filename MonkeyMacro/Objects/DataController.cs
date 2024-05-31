using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DataController
{
    private static DataController _instance;
    private FirestoreDb db;

    // Singleton 패턴을 사용하여 인스턴스를 하나만 유지
    public static DataController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DataController();
            }
            return _instance;
        }
    }

    // Firebase 클라이언트 초기화
    private DataController()
    {
        // DB 초기화
        string firebaseID = "monkeymacro-2e19a";

        string baseDirectory = @"D:\Programming\Development\Projects\MonkeyMacro\MonkeyMacro\"; // 자기 프로젝트 경로로 변경
        string keyDirectory = Path.Combine(baseDirectory, "Database", "key");
        string keyName = "monkeymacro-2e19a-firebase-adminsdk-kumu8-2f4f736de4.json";
        string keyPath = Path.Combine(keyDirectory, keyName);

        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyPath);
        db = FirestoreDb.Create(firebaseID);
    }

    // 사용자 계정 확인
    public async Task<bool> CheckUserAccount(string userName, string password)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);
            DocumentSnapshot snapshot = await userDocRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> userData = snapshot.ToDictionary();
                if (userData.ContainsKey("password") && userData["password"].ToString() == password)
                {
                    return true;
                }
            }
            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"사용자 계정 확인 중 오류 발생: {ex.Message}");
            return false;
        }
    }

    // 유저 정보 가져오기
    /*    public async Task<List<Dictionary<string, object>>> GetUserData(string userName)
        {
            try
            {
                DocumentReference userDocRef = db.Collection("users").Document(userName);
                DocumentSnapshot snapshot = await userDocRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    List<Dictionary<string, object>> userInfos = new List<Dictionary<string, object>>
                        {
                            snapshot.ToDictionary()
                        };
                    return userInfos;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"유저 정보를 가져오는 중 오류 발생: {ex.Message}");
                return null;
            }
        }*/

    // 단축키 추가
    public async Task AddShortCutKey(string userName, string applicationName, string keyName, Keys[] keyList)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);

            // 키 리스트를 문자열 배열로 변환
            string[] keyStrings = keyList.Select(k => k.ToString()).ToArray();

            // 업데이트할 데이터
            Dictionary<string, object> updates = new Dictionary<string, object>
                {
                    { $"shortcutKeyList.{applicationName}.{keyName}", keyStrings }
                };

            // 문서 업데이트
            await userDocRef.UpdateAsync(updates);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 추가 중 오류 발생: {ex.Message}");
        }
    }

    // 단축키 수정
    public async Task UpdateShortCutKey(string userName, string applicationName, string keyName, Keys[] keyList)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);

            // 키 리스트를 문자열 배열로 변환
            string[] keyStrings = keyList.Select(k => k.ToString()).ToArray();

            // 업데이트할 데이터
            Dictionary<string, object> updates = new Dictionary<string, object>
                {
                    { $"shortcutKeyList.{applicationName}.{keyName}", keyStrings }
                };

            // 문서 업데이트
            await userDocRef.UpdateAsync(updates);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 수정 중 오류 발생: {ex.Message}");
        }
    }

    // 단축키 삭제
    public async Task DeleteShortCutKey(string userName, string applicationName, string keyName)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);

            // 삭제할 단축키의 경로
            string shortcutKeyPath = $"shortcutKeyList.{applicationName}.{keyName}";

            // 업데이트할 데이터
            Dictionary<string, object> updates = new Dictionary<string, object>
        {
            { shortcutKeyPath, FieldValue.Delete }
        };
            // 문서 업데이트
            await userDocRef.UpdateAsync(updates);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 삭제 중 오류 발생: {ex.Message}");
        }
    }

    // 특정 프로그램 단축키 목록 삭제
    public async Task DeleteAppKeyList(string userName, string applicationName)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);

            // 삭제할 tracingApp의 경로
            string tracingAppPath = $"shortcutKeyList.{applicationName}";

            // 업데이트할 데이터
            Dictionary<string, object> updates = new Dictionary<string, object>
        {
            { tracingAppPath, FieldValue.Delete }
        };
            // 문서 업데이트
            await userDocRef.UpdateAsync(updates);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{applicationName}의 단축키 목록 삭제 중 오류 발생: {ex.Message}");
        }
    }


}