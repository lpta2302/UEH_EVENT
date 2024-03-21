using static Database;

using static Filterer;
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
        return QueryByKey<Student>(id);
    }
    public static Account? SignIn(string username, string password)
    {
        var acc = Query<Account>(
            new Filterer(
                new[] { "Username", "Password" },
                new[] { username, password },
                new[] { FilterType.Equal, FilterType.Equal })
        );
        if (acc == null) return null;
        return acc[0];
    }
    public static List<Sight> GetAllSight()
    {
        return Query<Sight>();
    }
    public static Sight? GetSpecificSight(int sightId)
    {
        return QueryByKey<Sight>(sightId);
    }
    public static Question? GetQuestion(int questionId)
    {
        return QueryByKey<Question>(questionId);
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
    public static List<Student>? FilterByTPoint(object value, FilterType filterType)
    {
        return Query<Student>(
            new Filterer(
                "TPoint",
                value,
                filterType
            )
        );
    }
}