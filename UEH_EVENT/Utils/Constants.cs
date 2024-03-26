

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
    public interface INavbar
    {
        public string[] Name { get; }
        public Type[] Forms { get; }
        public Image[] Icons { get; }
        public static void CreateNavbar(Form form, ComponentResourceManager resources)
        {
            INavbar navbar = GlobalData.Navbar;
            for (int i = 0; i < navbar.Name.Length; i++)
            {
                // Home
                // 
                Panel panel = new Panel();
                Button btn = new Button();

                panel.Controls.Add(btn);
                panel.Location = new Point(0, 93 + 75 * (i + 1));
                panel.Name = "panel" + navbar.Name[i];
                panel.Size = new Size(400, 75);
                panel.TabIndex = 7;
                // 
                // btnHomee
                // 
                btn.BackColor = Color.FromArgb(34, 34, 34);
                btn.BackgroundImageLayout = ImageLayout.None;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point);
                btn.ForeColor = Color.White;
                btn.Image = (Image)resources.GetObject($"btn{navbar.Name}.Image");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Location = new Point(0, -9);
                btn.Name = "btn" + navbar.Name[i];
                btn.Padding = new Padding(20, 0, 0, 0);
                btn.Size = new Size(419, 92);
                btn.TabIndex = 10;
                btn.Text = "  " + navbar.Name[i];
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.UseVisualStyleBackColor = false;
                btn.Image = navbar.Icons[i];
                btn.Click += (object sender, EventArgs e) => {
                    int index = Array.FindIndex(navbar.Name, item => item.Equals(((Control)sender).Text.Trim()));
                    form.Hide();
                    ((Form)Activator.CreateInstance(navbar.Forms[index])).ShowDialog();
                    form.Close();
                };

                form.Controls.Add(panel);
            }
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
    public class ClbNavbar : INavbar
    {
        public string[] Name { get; } = new string[]
        {
            "Cập nhật ĐRL",
            "Tạo trắc nghiệm",
            "Thống kê"
        };
        public Type[] Forms { get; } = new Type[] {
            typeof(formUpdateTPoint),
            typeof(formSight),
            typeof(formStatistic),
        };
        public Image[] Icons { get; } = new Image[]
        {
            UEH_EVENT.Properties.Resources.iconUpdate,
            UEH_EVENT.Properties.Resources.iconHome,
            UEH_EVENT.Properties.Resources.iconPoint
        };
    }
}