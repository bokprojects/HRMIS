using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMISver1.Helpers;
namespace HRMISver1.Employee
{    
    public partial class frmJobOpeningListing : Form
    {
        utility util;
        public JobOpeningInfo joiRef;
        public class JobOpeningInfo
        {
            public int JobID { get; set; }
            public string JobPosition { get; set; }
            public string JobDepartment { get; set; }
        }
        public frmJobOpeningListing()
        {
            InitializeComponent();
        }

        private void frmJobOpeningListing_Load(object sender, EventArgs e)
        {
            util = new utility();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string JobSelected = lvJobOpeningPosition.SelectedItems[0].Text;
            DialogResult dr = MessageBox.Show("Are you sure you want to select this job position?","Select Position: " + JobSelected, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                joiRef = new JobOpeningInfo();
                joiRef.JobID = util.isInteger(lvJobOpeningPosition.SelectedItems[0].Tag.ToString());
                joiRef.JobPosition = lvJobOpeningPosition.SelectedItems[0].Text;
                joiRef.JobDepartment = lvJobOpeningPosition.SelectedItems[0].SubItems[1].Text.ToString();
                this.Close();
            }
        }
    }
}
