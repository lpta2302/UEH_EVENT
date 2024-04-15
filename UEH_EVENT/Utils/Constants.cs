

using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UEH_EVENT.GUI;
using static Constants;
using UEH_EVENT.Properties;
using UEH_EVENT.Utils;
using System.ComponentModel;

public class Constants
{
    public static readonly string connectionString = @"
        Data Source=DESKTOP-H914KNH\SQLEXPRESS;
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
    public interface INavbar
    {
        public string[] Name { get; }
        public Type[] Forms { get; }
        public Image[] Icons { get; }
        public static void CreateNavbar(Form form, Panel Navbar)
        {
            INavbar navbar = GlobalData.Navbar;
            for (int i = 0; i < navbar.Name.Length; i++)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(form.GetType());
                // Home
                // 
                Panel panel = new Panel();
                Button btn = new Button();

                panel.Controls.Add(btn);
                if(i == 0)
                {
                    panel.Location = new Point(0, 113);
                    panel.Margin = new Padding(0,2,0,0);
                }
                else
                    panel.Location = new Point(0,120 + 63 * (i));
                panel.Name = "panel" + navbar.Name[i];
                panel.Size = new Size(400, 68);
                panel.TabIndex = 7;
                panel.BackColor = i == 0 ? Color.FromArgb(60,60,60) : Color.FromArgb(34, 34, 34);
                panel.BorderStyle = BorderStyle.FixedSingle;


                btn.BackColor = i == 0 ? Color.FromArgb(60, 60, 60) : Color.FromArgb(34, 34, 34);

                btn.BackgroundImageLayout = ImageLayout.None;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point);
                btn.ForeColor = Color.White;
                btn.Image = (Image)resources.GetObject($"btn{navbar.Name}.Image");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                //btn.Location = new Point(0, -17);
                btn.Name = "btn" + navbar.Name[i];
                btn.Padding = new Padding(20, 0, 0, 0);
                btn.Margin = new Padding(0);
                btn.Size = new Size(419, 68);
                btn.TabIndex = 10;
                btn.Text = "  " + navbar.Name[i];
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.UseVisualStyleBackColor = false;
                btn.Image = navbar.Icons[i];
                

                btn.Click += (object sender, EventArgs e) =>
                {
                    int index = Array.FindIndex(navbar.Name, item => item.Equals(((Control)sender).Text.Trim()));
                    form.Hide();
                    ((Form)Activator.CreateInstance(navbar.Forms[index])).ShowDialog();
                    form.Close();
                };

                Navbar.Controls.Add(panel);
            }
        }
    }

    public class StudentNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            GlobalData.CurrentAccount?.Name == null ? "Account" : GlobalData.CurrentAccount.Name,
            "Sight",
            "Game",
            "History",
            "Log Out"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formUpdateProfile),
            typeof(formSight),
            typeof(formGame),
            typeof(formHistory),
            typeof(LoginForm),  
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconAccount,
            UEH_EVENT.Properties.Resources.iconSight,
            UEH_EVENT.Properties.Resources.iconGame,
            UEH_EVENT.Properties.Resources.iconHistory,
            UEH_EVENT.Properties.Resources.iconLogOut
        };
    }
    public class AdminNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            GlobalData.CurrentAccount?.Name == null ? "Account" : GlobalData.CurrentAccount.Name,
            "Manage Account",
            "Manage Sight",
            "Statistic",
            "Log Out"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formUpdateProfile),
            typeof(formManageAccount),
            typeof(formManageSight),
            typeof(formStatistic),
            typeof(LoginForm)
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconAccount,
            UEH_EVENT.Properties.Resources.iconManage,
            UEH_EVENT.Properties.Resources.iconUpdate,
            UEH_EVENT.Properties.Resources.iconPoint,
            UEH_EVENT.Properties.Resources.iconLogOut
        };
    }
    public class ClbNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            GlobalData.CurrentAccount?.Name == null ? "Account" : GlobalData.CurrentAccount.Name,
            "Update points",
            "Create Sight",
            "Statistic",
            "Log Out"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formUpdateProfile),
            typeof(formUpdateTPoint),
            typeof(formLobbySight),
            typeof(formStatistic),
            typeof(LoginForm)
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconAccount,
            UEH_EVENT.Properties.Resources.iconUpdate,
            UEH_EVENT.Properties.Resources.iconUpdateSight,
            UEH_EVENT.Properties.Resources.iconPoint,
            UEH_EVENT.Properties.Resources.iconLogOut
        };
    }

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