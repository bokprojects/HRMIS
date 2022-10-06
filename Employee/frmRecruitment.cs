using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMISver1.Employee
{
    public partial class frmRecruitment : Form
    {
        public frmRecruitment()
        {
            InitializeComponent();
        }
        private void TCMenus(int indexTab)
        {            
            tcMenus.SelectedIndex = indexTab - 1;         
        }
        private void frmRecruitment_Load(object sender, EventArgs e)
        {

        }

        private void btnJobPosting_Click(object sender, EventArgs e)
        {
            TCMenus(1);
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            TCMenus(2);
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            TCMenus(3);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            TCMenus(4);
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will open your Open Position Job Listing. Would you like to continue?", "Open Job Listing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                frmJobOpeningListing jobOpening = new frmJobOpeningListing();
                frmJobOpeningListing.JobOpeningInfo joi = new frmJobOpeningListing.JobOpeningInfo();                
                jobOpening.ShowDialog();
                joi = jobOpening.joiRef;
                if(joi != null)
                {
                    tbPositionTitle.Text = joi.JobPosition;
                    cmbDepartment.Text = joi.JobDepartment;
                }
            }
        }
    }
}
