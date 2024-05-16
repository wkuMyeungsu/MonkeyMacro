using System.Threading.Tasks;

public class DataStore
{
    private static DataStore _instance;
    public UserData UserData { get; private set; }

    // Singleton 패턴을 사용하여 인스턴스를 하나만 유지
    public static DataStore Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DataStore();
            }
            return _instance;
        }
    }

    private DataStore() { }

    // 데이터 로드
    public async Task LoadDataAsync()
    {
        UserData = await Database.Instance.GetDataAsync<UserData>("Users");
    }
}

public class UserData
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    // 다른 속성들 추가
}