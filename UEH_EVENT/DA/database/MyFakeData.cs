class MyFakeData
{
    private static void FakeStudentData()
    {
        List<Student> students = new()
        {
            new Student("31221020084", "Thiên Ân", "K48", "SE001", "KTPM", 92),
            new Student("31221020027", "Thien An", "K47", "KPM06", "HTTTQL", 59)
        };
        Database.Insert(students);
    }
    private static void FakeAccountData()
    {
        List<Account> accounts = new();
        var st = Query.GetStudentById("31221020084");
        if (st == null) return;
        accounts.Add(new Account(st.Mssv, "password", "TK01", Constants.STUDENT_ACC, st.Mssv));
        st = Query.GetStudentById("31221020027");
        if (st == null) return;
        accounts.Add(new Account(st.Mssv, "password", "TK02", Constants.STUDENT_ACC, st.Mssv));

        accounts.Add(new Account("lpta2302", "password", "Thien An", Constants.ADMIN_ACC));
        accounts.Add(new Account("lpta2324", "password", "Thien An CLB", Constants.CLB_ACC));

        Database.Insert(accounts);
    }
    private static void FakeSight()
    {
        Answer a1 = new() { Content = "Đây là đáp án 1(đúng)", IsKeyAnswer = true };
        Answer a2 = new() { Content = "Đây là đáp án 2(sai)" };
        Answer a3 = new() { Content = "Đây là đáp án 3(sai)" };
        Answer a4 = new() { Content = "Đây là đáp án 4(sai)" };
        Question q1 = new()
        {
            Content = "Đây là câu hỏi 1",
            Answers = new List<Answer>() { a1, a2, a3, a4 },
        };
        a1 = new Answer() { Content = "Đây là đáp án 1(sai)" };
        a2 = new Answer() { Content = "Đây là đáp án 2(đúng)", IsKeyAnswer = true };
        a3 = new Answer() { Content = "Đây là đáp án 3(sai)" };
        a4 = new Answer() { Content = "Đây là đáp án 4(sai)" };
        Question q2 = new()
        {
            Content = "Đây là câu hỏi 1",
            Answers = new List<Answer>() { a1, a2, a3, a4 },
        };

        Sight s = new()
        {
            Time = 1200,
            Name = "Bài trắc nghiệm",
            Preview = "đây là bài trắc nghiệm nhân phẩm",
            Questions = new List<Question>() { q1, q2 },
            CreatedById = 4
        };
        Database.Insert(s);
    }
    private static void FakeSightHis()
    {
        var st = Query.GetStudentById("31221020084");
        var s = Query.GetSpecificSight(1);
        SightHis sightHis = new(st!.Mssv, s!.Id, 2);
        Database.Insert(sightHis);
    }
    private static void FakeGame()
    {
        List<Game> games = new(){
            new Game("Mario")
        };
        Database.Insert(games);
    }
    private static void FakePlayGameHis()
    {
        PlayHis playHis = new("31221020084", 1, 98);
        Database.Insert(playHis);
    }
    private static void FakeTPointHis()
    {
        TPointHis pointHis = new("31221020027", 2, "test đây là một đoạn test dày vài chục trăm kí tự");
        TPointHis pointHis1 = new("31221020084", 1, "test đây là một đoạn test dày vài chục trăm kí tự");
        Database.Insert(pointHis);
        Database.Insert(pointHis1);
    }
    public static void Init()
    {
        FakeStudentData();
        FakeAccountData();
        FakeSight();
        FakeSightHis();
        FakeGame();
        FakePlayGameHis();
        FakeTPointHis();
    }
}