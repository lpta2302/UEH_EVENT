using System.Collections.Generic;

class MyFakeData
{
    private static void FakeStudentData()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("31221020084", "Thiên Ân", "K48", "SE001", "KTPM", 92));
        students.Add(new Student("31221020027", "Thien An", "K47", "KPM06", "HTTTQL", 59));
        Database.Insert(students);
    }
    private static void FakeAccountData()
    {
        List<Account> accounts = new List<Account>();
        var st = Query.GetStudentById("31221020084");
        if (st == null) return;
        accounts.Add(new Account(st.Mssv, "password1", "TK01", Constants.STUDENT_ACC, st.Mssv));
        st = Query.GetStudentById("31221020027");
        if (st == null) return;
        accounts.Add(new Account(st.Mssv, "password2", "TK02", Constants.STUDENT_ACC, st.Mssv));

        accounts.Add(new Account("lpta2302", "password2", "Thien An", Constants.ADMIN_ACC));

        Database.Insert(accounts);
    }
    private static void FakeSight()
    {
        List<Question> questions = new List<Question>();
        Random r = new Random();
        for (int i = 0; i < 2; i++)
        {
            int x = r.Next(1, 5);
            Answer a1 = new Answer() { Content = $"Đây là đáp án 1{x == 1}", IsKeyAnswer = x == 1 };
            Answer a2 = new Answer() { Content = $"Đây là đáp án 2{x == 2}", IsKeyAnswer = x == 2 };
            Answer a3 = new Answer() { Content = $"Đây là đáp án 3{x == 3}", IsKeyAnswer = x == 3 };
            Answer a4 = new Answer() { Content = $"Đây là đáp án 4{x == 4}", IsKeyAnswer = x == 4 };
            Question q1 = new Question()
            {
                Content = "Đây là câu hỏi 1",
                Answers = new List<Answer>() { a1, a2, a3, a4 },
            };
            questions.Add(q1);
        }

            Sight s = new Sight()
            {
                Name = "Bài trắc nghiệm",
                Preview = "đây là bài trắc nghiệm nhân phẩm",
                Questions = questions
            };
        Database.Insert(s);
    }
    private static void FakeSightHis()
    {
        var st = Query.GetStudentById("31221020084");
        var s = Query.GetSpecificSight(1);
        SightHis sightHis = new SightHis(st.Mssv, s.Id, 100);
        Database.Insert(sightHis);
    }
    private static void FakeGame()
    {
        List<Game> games = new List<Game>(){
            new Game("game 1"),
            new Game("game 2")
        };
        Database.Insert(games);
    }
    private static void FakePlayGameHis()
    {
        PlayHis playHis = new PlayHis("31221020084", 1, 98);
        Database.Insert(playHis);
    }
    private static void FakeTPointHis()
    {
        TPointHis pointHis = new TPointHis("31221020027", 2, "test đây là một đoạn test dày vài chục trăm kí tự");
        Database.Insert(pointHis);
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