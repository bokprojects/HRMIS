using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMISver1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the system", "Exit Application?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jobHiringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmRecruitment recruitment = new Employee.frmRecruitment();
            this.IsMdiContainer = true;
            recruitment.StartPosition = FormStartPosition.Manual;
            recruitment.Location = new Point(0, 0);
            recruitment.Top = 0;
            recruitment.Left = 0;
            recruitment.MdiParent = this;
            recruitment.Show();
        }
    }
}
