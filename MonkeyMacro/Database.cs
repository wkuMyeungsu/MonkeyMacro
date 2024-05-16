using Firebase.Database;
using System.Threading.Tasks;

public class Database
{
    private static Database _instance;
    private FirebaseClient _client;

    // Singleton 패턴을 사용하여 인스턴스를 하나만 유지
    public static Database Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }
    }

    // Firebase 클라이언트 초기화
    private Database()
    {
/*        _client = new FirebaseClient(
            "https://your-database-url.firebaseio.com/",
            new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult("your-firebase-database-secret")
            });*/
    }

    // 데이터 가져오기
    public async Task<T> GetDataAsync<T>(string path)
    {
        return await _client
            .Child(path)
            .OnceSingleAsync<T>();
    }

    // 데이터 쓰기
    public async Task SetDataAsync<T>(string path, T data)
    {
        await _client
            .Child(path)
            .PutAsync(data);
    }
}