using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI
{
    public partial class formManageAccount : Form
    {
        List<Account> accounts;
        private void loadListView()
        {
            lstAccount.Items.Clear();
            int stt = 1;
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(account.Username);
                item.SubItems.Add(account.Password);
                item.SubItems.Add(account.Name);
                item.SubItems.Add(account.AccType);
                lstAccount.Items.Add(item);
                stt++;
            }

        }
        public formManageAccount()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void formManagement_Load(object sender, EventArgs e)
        {
            cbbAccType.Items.AddRange(new string[] { Constants.STUDENT_ACC, Constants.CLB_ACC, Constants.ADMIN_ACC });
        }
        private void gotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        private void search(object sender)
        {
            SearchWildcard searcher = new SearchWildcard();
            if (sender is TextBox)
            {
                TextBox textbox = (TextBox)sender;
                if (textbox.Name == "txtName")
                    accounts = Query.GetAccountByName(((TextBox)sender).Text);
                else
                    accounts = Query.GetAccountByUsername(((TextBox)sender).Text);
            }
            else if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                accounts = Query.GetAccountsByType((string)comboBox.SelectedItem);
            }
            loadListView();
        }

        private void cbbAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
                search(sender);
        }

        private void enterTrigger(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(sender);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstAccount.SelectedIndices.Count == 0)
                MessageBox.Show("Chưa chọn tài khoản nào");
            Hide();
            new formUpdateProfile(accounts[lstAccount.SelectedIndices[0]]).ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateAccount().ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database.Delete<Account>(accounts[lstAccount.SelectedIndices[0]]);
            accounts.RemoveAt(lstAccount.SelectedIndices[0]);
            lstAccount.Items.RemoveAt(lstAccount.SelectedIndices[0]);
        }
    }
}
