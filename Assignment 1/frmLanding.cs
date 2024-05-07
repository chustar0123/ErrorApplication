using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        private void btnViewStudyFrm_Click(object sender, EventArgs e)
        {
            frmStudy form = new frmStudy();
            form.Show();
            this.Hide();
        }

        private void btnViewTopics_Click(object sender, EventArgs e)
        {
            frmTopic form = new frmTopic();
            form.Show();
            this.Hide();
        }

        private void btnViewErrors_Click(object sender, EventArgs e)
        {
            frmError form = new frmError();
            form.Show();
            this.Hide();
        }

        private void btnViewSolutions_Click(object sender, EventArgs e)
        {
           frmSolution form = new frmSolution();
            form.Show();
            this.Hide();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            frmErrorSearch form = new frmErrorSearch();
            form.Show();
            this.Hide();
        }

        private void frmLanding_Load(object sender, EventArgs e)
        {

        }
    }
}
