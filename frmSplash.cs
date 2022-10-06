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
    public partial class frmSplash : Form
    {
        int Percent = 100;
        int StartCount = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmr_Start_Tick(object sender, EventArgs e)
        {
            StartCount += 20;

            if(StartCount <= 100)
                pbProgress.Value = StartCount;

            if(StartCount == Percent)
            {
                MainForm frmMain = new MainForm();
                frmMain.Show();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
