class Stats
{
    public static int CountAll<T>() where T : class
    {
        if (nameof(T).EndsWith("His"))
        {
            return Database.Query<T>(true).Count;
        }
        else
        {
            return Database.Query<T>().Count;
        }
    }
    public static int CountFilterString<T>(string propName, string value) where T : class
    {
        return Database.Query<T>(new Filterer(propName, value, Filterer.FilterType.Equal))!.Count;
    }
    public static int CountFilterInt<T>(string propName, char filter, int threshold) where T : class
    {
        Dictionary<char, Func<Filterer>> filterCases = new()
        {
            { '>', () => new Filterer(propName, threshold, Filterer.FilterType.GreaterThan) },
            { '=', () => new Filterer(propName, threshold, Filterer.FilterType.Equal) },
            { '<', () => new Filterer(propName, threshold, Filterer.FilterType.LessThan) }
        };
        return Database.Query<T>(filterCases[filter].Invoke())!.Count;
    }
    public static int CountFilterInt<T>(string propName, string equalFilter, int threshold) where T : class
    {
        int result = CountFilterInt<T>(propName, '=', threshold);
        if (equalFilter == ">=")
        {
            result += CountFilterInt<T>(propName, '>', threshold);
        }
        if (equalFilter == "<=")
        {
            result += CountFilterInt<T>(propName, '<', threshold);
        }
        return result;
    }
    public static int CountFilterInt(string className, string propName, int lowerBound, int upperBound)
    {
        return Search.SearchInt(className, propName, lowerBound, upperBound).Count;
    }
    // Thống kê bài trắc nghiệm
    public static int CountAllSights()
    {
        return Query.GetAllSight().Count;
    }
    public static int CountSightHisByPoint(int threshold)
    {
        return Query.GetAllSightHis()
            .Where(sh => sh.Point >= threshold).Count();
    }
    // Thống kê điểm rèn luyện
    public static int CountAllStudents()
    {
        return Query.GetAllStudent().Count;
    }
    public static int CountStudentsByTPoints(int threshold)
    {
        return Query.GetAllStudent()
            .Where(st => st.TPoint >= threshold).Count();
    }
    public static int CountStudentsByTPoints(int minimum, int maximum)
    {
        return Query.GetAllStudent()
            .Where(st => st.TPoint >= minimum && st.TPoint <= maximum).Count();
    }
    // Thống kê game
    public static int CountAllPlayHis()
    {
        return Query.GetAllPlayHis().Count;
    }
    public static int CountPlayHisByGame(int gameId)
    {
        return Query.GetAllPlayHis()
            .Where(ph => ph.GameId == gameId).Count();
    }
    public static int CountPlayHisByPoint(int threshold)
    {
        return Query.GetAllPlayHis()
            .Where(ph => ph.Point >= threshold).Count();
    }
    public static int CountPlayHisByPoint(int minimum, int maximum)
    {
        return Query.GetAllPlayHis()
            .Where(ph => ph.Point >= minimum && ph.Point <= maximum).Count();
    }
    // Thống kê người chơi
    public static int CountAllAccounts()
    {
        return Query.GetAllAccount().Count;
    }
    public static int CountAllAccountsByType(string accType)
    {
        return Query.GetAllAccount()
            .Where(acc => acc.AccType == accType).Count();
    }
}
