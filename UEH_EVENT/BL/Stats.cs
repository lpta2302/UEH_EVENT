class Stats
{
    // Thống kê bài trắc nghiệm
    public static int CountAllSights()
    {
        return Query.GetAllSight().Count;
    }
    public static int CountSightHisById(int sightId)
    {
        return Query.GetAllSightHis()
            .Where(sh => sh.SightId == sightId).Count();
    }
    public static int CountSightHisByPoint(int threshold)
    {
        return Query.GetAllSightHis()
            .Where(sh => sh.Point >= threshold).Count();
    }
    // Thống kê điểm rèn luyện
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
