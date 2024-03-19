

using System.Collections;
using System.Runtime.InteropServices;
using UEH_EVENT.GUI;

public class Constants
{
    public static string connectionString = @"
        Data Source=LAPTOP-H28D0O8N\SQLEXPRESS;
        Initial Catalog= test;
        Integrated Security=True;
        TrustServerCertificate=True;
    ";
    public static string STUDENT_ACC { get; } = "Student";
    public static string ADMIN_ACC { get; } = "Admin";
    public static string CLB_ACC { get; } = "CLB";
    static Constants()
    {
        STUDENT_ACC = "Student";
        ADMIN_ACC = "Admin";
        CLB_ACC = "CLB";
    }
    public static INavbar? GetNavbar(string type)
    {
        if(type.Equals(STUDENT_ACC)) return new StudentNavbar();
        if(type.Equals(ADMIN_ACC))   return new AdminNavbar();
        if (type.Equals(CLB_ACC)) return new ClbNavbar();
        return null;
    }
    public interface INavbar
    {
        public string[] Name { get; }
        public Type[] Forms { get; }
        public Image[] Icons { get; }
        public Form CreateNavitem(int i)
        {
            return (Form)Activator.CreateInstance(Forms[i]);
        }
    }

    public class StudentNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            "Bài trắc nghiệm",
            "Game",
            "Thống kê"
        };
        public Type[] Forms { get; } = new Type[] { 
            typeof(formSight),
            typeof(formGame),
            typeof(formStatistic),
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconHome,
            UEH_EVENT.Properties.Resources.iconGame,
            UEH_EVENT.Properties.Resources.iconPoint
        };
    }
    public class AdminNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            "Tài Khoản",
            "Game",
            "Thống kê"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formManagement),
            typeof(formGame),
            typeof(formStatistic),
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconHome,
            UEH_EVENT.Properties.Resources.iconGame,
            UEH_EVENT.Properties.Resources.iconPoint
        };
    }
    public class ClbNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            "Bài trắc nghiệm",
            "Game",
            "Thống kê"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formSight)   ,
            typeof(formGame),
            typeof(formStatistic),
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconHome,
            UEH_EVENT.Properties.Resources.iconGame,
            UEH_EVENT.Properties.Resources.iconPoint
        };
    }
}