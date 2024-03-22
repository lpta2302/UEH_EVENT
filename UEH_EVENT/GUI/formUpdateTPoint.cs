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
    public partial class formUpdateTPoint : Form
    {
        public formUpdateTPoint()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formUpdateTPoint_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student? st = null;
            string s = ((TextBox)sender).Text;
            if (double.TryParse(s, out double value))
            {
                st = Query.GetStudentById(s);
            }
            else
            {
                st = Database.Query<Student>("Name", s);
            }
        }



        private void txtEnter_MouseEnter(object sender, EventArgs e)
        {
            txtEnter.Text = "";
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listSV.DataSource = Query.GetAllStudent()[0];
        }

       
    }
}
