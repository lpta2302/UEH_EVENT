using static Database;
class Query
{
    public static List<Student> GetAllStudent()
    {
        return Query<Student>();
    }
    public static List<Account> GetAllAccount()
    {
        return Query<Account>();
    }
    public static Student? GetStudentById(string id)
    {
        return Query<Student>(id);
    }
    public static Account? SignIn(string username, string password)
    {
        var acc = Query<Account>(username, "Username");
        if (acc == null) return null;
        return acc;
    }
    public static List<Sight> GetAllSight()
    {
        return Query<Sight>();
    }
    public static Sight? GetSpecificSight(int sightId)
    {
        return Query<Sight>(sightId);
    }
    public static Question? GetQuestion(int questionId)
    {
        return Query<Question>(questionId);
    }
    public static List<Game> GetAllGame()
    {
        return Query<Game>();
    }
    public static List<SightHis> GetAllSightHis()
    {
        return Query<SightHis>(true);
    }
    public static List<PlayHis> GetAllPlayHis()
    {
        return Query<PlayHis>(true);
    }
    public static List<TPointHis> GetAllTPointHis()
    {
        return Query<TPointHis>(true);
    }
}