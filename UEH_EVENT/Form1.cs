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
    }
}