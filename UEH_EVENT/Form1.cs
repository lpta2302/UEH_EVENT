using UEH_EVENT.GUI;

namespace UEH_EVENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyFakeData.Init();
            dataGridView1.DataSource = Query.GetAllAccount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch search = new();
            search.Show();
        }
    }
}