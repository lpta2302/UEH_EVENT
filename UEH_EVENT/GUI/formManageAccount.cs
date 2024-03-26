using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UEH_EVENT.GUI
{
    public partial class formManageAccount : Form
    {
        private void loadListView(List<Account> accounts)
        {
            int stt = 1;
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(account.Username);
                item.SubItems.Add(account.Password);
                item.SubItems.Add(account.Name);
                lstAccount.Items.Add(item);
                stt++;
            }

        }
        public formManageAccount()
        {
            InitializeComponent();
        }

        private void formManagement_Load(object sender, EventArgs e)
        {
            loadListView(Query.GetAllAccount());
        }

        private void btntao_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
