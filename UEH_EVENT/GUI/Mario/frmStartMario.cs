using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace UEH_EVENT.GUI.Mario
{
    public partial class frmStartMario : Form
    {
        public frmStartMario()
        {
            InitializeComponent();
            this.FormClosing += frmStartMario_FormClosing;
        }

        private void bgwProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (bgwProcess.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(50);
                bgwProcess.ReportProgress(i);
            }
        }

        private void bgwProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbLoadMarioPlay.Value = e.ProgressPercentage;
        }

        private void bgwProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Quá trình đã bị hủy.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + e.Error.Message);
            }
            else
            {
                this.Hide();
                frmPlayMario frmPlay = new frmPlayMario();
                frmPlay.ShowDialog();
                Close();
                //sPlayer.Stop();
            }
        }

        private void picButtonStart_Click(object sender, EventArgs e)
        {
            pgbLoadMarioPlay.Value = 0;
            bgwProcess.RunWorkerAsync();
        }

        private void picButtonCancel_Click(object sender, EventArgs e)
        {
            if (bgwProcess.IsBusy)
            {
                bgwProcess.CancelAsync();
            }
        }

        private void picButtonDiscription_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*private void frmStartMario_Load(object sender, EventArgs e)
        {

            sPlayer.Play();
        }*/

        private void frmStartMario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwProcess.IsBusy)
            {
                bgwProcess.CancelAsync();
                while (bgwProcess.IsBusy)
                {
                    Application.DoEvents();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            new formGame().ShowDialog();
            Close();
        }
    }
}
