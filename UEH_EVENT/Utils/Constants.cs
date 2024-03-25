public class Constants
{
    public static readonly string connectionString = @"
        Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog= test;
        Integrated Security=True;
        TrustServerCertificate=True;
    ";
    public static readonly string STUDENT_ACC = "Student";
    public static readonly string ADMIN_ACC = "Admin";
    public static readonly string CLB_ACC = "CLB";

    public const string STR_ACCOUNT = "Tài khoản";
    public const string STR_GAME = "Trò chơi";
    public const string STR_PLAY_HIS = "Lịch sử chơi";
    public const string STR_SIGHT = "Bài trắc nghiệm";
    public const string STR_SIGHT_HIS = "Lịch sử làm trắc nghiệm";
    public const string STR_STUDENT = "Sinh viên";
    public const string STR_TPOINT_HIS = "Lịch sử cộng điểm";

    public static readonly Dictionary<string, string> CLASS_NAMES = new()
    {
        { "Placeholder", "(select)" },
        { nameof(Account), STR_ACCOUNT },
        { nameof(Game), STR_GAME },
        { nameof(PlayHis), STR_PLAY_HIS },
        { nameof(Sight), STR_SIGHT },
        { nameof(SightHis), STR_SIGHT_HIS },
        { nameof(Student), STR_STUDENT },
        { nameof(TPointHis), STR_TPOINT_HIS },
    };
}