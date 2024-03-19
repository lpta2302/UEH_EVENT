using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Constants;

namespace UEH_EVENT.GUI
{
    public partial class formTrainingPoint : Form
    {
        private formGame game;

        public formTrainingPoint()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                game = new formGame();
                game.FormClosed += TrainingPoint_FormClosed;
                Hide();
                game.WindowState = FormWindowState.Maximized; // Đặt form game thành toàn màn hình
                game.Show();
            }
            else
            {
                game.Activate();
            }
        }

        private void TrainingPoint_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
