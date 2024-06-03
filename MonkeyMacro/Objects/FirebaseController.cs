using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FirebaseController
{
    private static FirebaseController _instance;
    private FirestoreDb db;

    // Singleton 패턴을 사용하여 인스턴스를 하나만 유지
    public static FirebaseController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new FirebaseController();
            }
            return _instance;
        }
    }

    // Firebase 클라이언트 초기화
    private FirebaseController()
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

    public async Task<Dictionary<string, object>> GetUserData(string userName)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);
            DocumentSnapshot snapshot = await userDocRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                // 전체 문서 데이터를 반환
                return snapshot.ToDictionary();
            }
            else
            {
                // 사용자 데이터가 없는 경우 로그 기록이나 적절한 처리를 할 수 있습니다.
                Debug.WriteLine($"No data found for user: {userName}");
            }
        }
        catch (Exception ex)
        {
            // Firestore 조회 중 오류가 발생한 경우 처리
            Debug.WriteLine($"Error retrieving user data for {userName}: {ex.Message}");
        }
        return null; // 예외 발생 또는 데이터가 없을 경우 null 반환
    }



    // 단축키 추가 또는 업데이트
    public async Task<bool> SetUserShortcut(string userName, string applicationName, string shortcutName, string[] keys)
    {
        try
        {
            DocumentReference userDocRef = db.Collection("Users").Document(userName);

            // 단축키 데이터를 직접 구조화하여 저장
            var shortcutData = new Dictionary<string, object>
            {
                [applicationName] = new Dictionary<string, object>
                {
                    [shortcutName] = keys
                }
            };

            // Firestore 문서 내에 'appsShortcutDict' 필드에 단축키 정보 추가
            var update = new Dictionary<string, object>
        {
            { "appsShortcutDict", shortcutData }
        };

            // SetAsync를 사용하여 데이터 병합
            await userDocRef.SetAsync(update, SetOptions.MergeAll);
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 추가 중 오류 발생: {ex.Message}");
            return false;
        }
    }

    // 단축키 삭제 및 애플리케이션 체크하여 삭제
    public async Task<bool> DeleteUserShortcut(string userName, string applicationName, string shortcutName)
    {
        try
        {
            DocumentReference docRef = db.Collection("Users").Document(userName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                string appPath = $"appsShortcutDict.{applicationName}";
                string shortcutPath = $"{appPath}.{shortcutName}";

                // 단축키 삭제
                Dictionary<string, object> updates = new Dictionary<string, object> { { shortcutPath, FieldValue.Delete } };
                await docRef.UpdateAsync(updates);

                // 애플리케이션 내 다른 단축키가 있는지 확인
                if (snapshot.TryGetValue<Dictionary<string, object>>(appPath, out var appShortcuts) && appShortcuts != null)
                {
                    appShortcuts.Remove(shortcutName);
                    if (appShortcuts.Count == 0)
                    {
                        // 더 이상 단축키가 없으면 애플리케이션 항목도 삭제
                        updates = new Dictionary<string, object> { { appPath, FieldValue.Delete } };
                        await docRef.UpdateAsync(updates);
                    }
                }
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 삭제 오류: {ex.Message}");
            return false;
        }
    }

    // 단축키 조회
    public async Task<string[]> GetUserShortcut(string userName, string applicationName, string shortcutName)
    {
        try
        {
            DocumentReference docRef = db.Collection("Users").Document(userName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                // appsShortcutDict에서 applicationName과 shortcutName에 해당하는 값을 조회
                string basePath = $"appsShortcutDict.{applicationName}";
                if (snapshot.TryGetValue<Dictionary<string, object>>(basePath, out var appShortcuts) && appShortcuts != null)
                {
                    // application 내부의 shortcutName에 해당하는 키 배열 조회
                    if (appShortcuts.TryGetValue(shortcutName, out var shortcutKeysObj) && shortcutKeysObj is string[])
                    {
                        return (string[])shortcutKeysObj;
                    }
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"단축키 조회 오류: {ex.Message}");
            return null;
        }
    }

    // 사용자 설정 업데이트
    public async Task<bool> UpdateUserSettings(string userName, int opacity, bool topMost, bool useTrayMinimize)
    {
        try
        {
            DocumentReference docRef = db.Collection("Users").Document(userName);
            // 필드 경로 직접 지정 대신 설정 구조화
            var settings = new Dictionary<string, object>
        {
            { "userSettings", new Dictionary<string, object>
                {
                    { "opacity", opacity },
                    { "topMost", topMost },
                    { "useTrayMinimize", useTrayMinimize}
                }
            }
        };
            await docRef.SetAsync(settings, SetOptions.MergeAll);
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"사용자 설정 업데이트 오류: {ex.Message}");
            return false;
        }
    }

    // 사용자 설정 조회
    public async Task<Dictionary<string, object>> GetUserSettings(string userName)
    {
        try
        {
            DocumentReference docRef = db.Collection("Users").Document(userName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                var settings = snapshot.GetValue<Dictionary<string, object>>("userSettings");
                return settings;
            }
            return null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"사용자 설정 조회 오류: {ex.Message}");
            return null;
        }
    }

}