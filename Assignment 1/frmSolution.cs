using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_1
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void frmSolution_Load(object sender, EventArgs e)
        {
            string[] Error;
            string perError = "";
            StreamReader errorD = new StreamReader("Error.txt");
            while ((perError = errorD.ReadLine()) != null)
            {
                Error = perError.Split('#');
                cmbErrorDescr.Items.Add(Error[1]);
            }
            errorD.Close();



            string[] field;
            string record = "";
            StreamReader readStudyYear = new StreamReader("Study.txt");
            while ((record = readStudyYear.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbStudyDescr.Items.Add(field[1]);
            }

            readStudyYear.Close();

            string[] topics;
            string perTopic = "";
            StreamReader readTopics = new StreamReader("topic.txt");
            while ((perTopic = readTopics.ReadLine()) != null)
            {
                topics = perTopic.Split('#');
                cmbTopicDescr.Items.Add(topics[1]);
            }
            readTopics.Close();

            
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmLanding form = new frmLanding();
            form.Show();
            this.Close();
        }
        int solutionId = 10000;
        private void btnInsertSolution_Click(object sender, EventArgs e)
        {
            
            txtErrorID.Text = solutionId.ToString();
            txtErrorID.Enabled = false;
            solutionId = int.Parse(txtErrorID.Text);
            solutionId++;
            StreamWriter writeSolution = new StreamWriter("Solution.txt", true);
            writeSolution.WriteLine(txtErrorID.Text + "#" + txtSolutionDescription.Text + "#" +cmbErrorDescr.SelectedItem.ToString() + "#" + cmbStudyDescr.SelectedItem.ToString() + "#" + cmbTopicDescr.SelectedItem.ToString() + "#" + dateError.Text);
            writeSolution.Close();

            /*lstSolutionLists.Items.Add(txtErrorID.Text + "\t" + txtSolutionDescription.Text + "\t" + cmbErrorDescr.SelectedItem.ToString() + "\t" + cmbStudyDescr.SelectedItem.ToString() + "\t" + cmbTopicDescr.SelectedItem.ToString() + "\t" + dateError.Text);*/
            /*IbINumberOfSolutions.Text = lstSolutionLists.Items.Count.ToString();*/



        }

        private void btnListError_Click(object sender, EventArgs e)
        {
            lstSolutionLists.Items.Clear();
            StreamReader read = new StreamReader("Solution.txt");
            String[] field;
            String record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstSolutionLists.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4] + "\t" + field[5]);
                IbINumberOfSolutions.Text = lstSolutionLists.Items.Count.ToString();
            }
            read.Close();
        }
    }
}
