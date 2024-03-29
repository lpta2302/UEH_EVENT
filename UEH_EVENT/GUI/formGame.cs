using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UEH_EVENT.GUI.Mario;

namespace UEH_EVENT.GUI
{
    public partial class formGame : Form
    {
        private object trainingPoint;

        public formGame()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void btnTrainingpoint_Click(object sender, EventArgs e)
        {
            /*if (trainingPoint == null)
            {
                trainingPoint = new formTrainingPoint();
                trainingPoint.FormClosed += TrainingPoint_FormClosed;
                Hide();
                trainingPoint.WindowState = FormWindowState.Maximized; // Đặt form trainingPoint thành toàn màn hình
                trainingPoint.Show();
            }
            else
            {
                trainingPoint.Activate();
            }
            */
        }

        private void TrainingPoint_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void Navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStartMario().ShowDialog();
            Close();
        }
    }
}
