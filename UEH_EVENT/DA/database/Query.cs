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
    public static List<Account>? GetAccountByName(string s)
    {
        return Query<Account>(new Filterer("Name", s, Filterer.FilterType.Equal));
    }
    public static List<Account>? GetAccountByUsername(string s)
    {
        return Query<Account>(new Filterer("Username", s, Filterer.FilterType.Equal));
    }
    public static List<Account>? GetAccountsByType(string s)
    {
        return Query<Account>(new Filterer("AccType", s, Filterer.FilterType.Equal));
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
        if (acc.Count == 0) return null;
        return acc[0];
    }
    public static List<Sight> GetAllSight()
    {
        return Query<Sight>(true
            );
    }
    public static Sight? GetSpecificSight(int sightId)
    {
        return QueryByKey<Sight>(sightId);
    }
    public static List<Sight>? GetSightsByName(string s)
    {
        return Query<Sight>(new Filterer("Name", s, Filterer.FilterType.Equal));
    }
    public static List<Sight>? GetSightsByCreatedById(object key)
    {
        return Query<Sight>(new Filterer("CreatedById", key, Filterer.FilterType.Equal));
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
    public static List<SightHis>? GetSightHisByStudentId(object id)
    {
        return Query<SightHis>(new Filterer("StudentId", id, FilterType.Equal), false, true);
    }
    public static List<TPointHis>? GetTPointHisByStudentId(object id)
    {
        return Query<TPointHis>(new Filterer("StudentId", id, FilterType.Equal), false, true);
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