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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            string[] field;
            StreamReader readStudyYear = new StreamReader("Study.txt");
            string record = "";
            while ((record = readStudyYear.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbStudyDescri.Items.Add(field[1]);
            }

            readStudyYear.Close();

            string[] topics;
            StreamReader readTopics = new StreamReader("topic.txt");
            string perTopic = "";
            while ((perTopic = readTopics.ReadLine()) != null)
            {
                topics = perTopic.Split('#');
                cmbTopicDescri.Items.Add(topics[1]);
            }
            readTopics.Close();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmLanding form = new frmLanding();
            form.Show();
            this.Close();

        }
        int errorId = 100000;
        private void btnInsertError_Click(object sender, EventArgs e)
        {
            
            txtErrorID.Text = errorId.ToString();
            txtErrorID.Enabled = false;
            errorId = int.Parse(txtErrorID.Text);
            errorId++;

            StreamWriter writeError = new StreamWriter("error.txt", true);
            writeError.WriteLine(txtErrorID.Text + "#" + txtErrorDescr.Text + "#" + cmbStudyDescri.SelectedItem.ToString() + "#" + cmbTopicDescri.SelectedItem.ToString() + "#" + dateError.Text );
            writeError.Close();

           /* lstErrorLists.Items.Add(txtErrorID.Text + "\t" + txtErrorDescr.Text + "\t" + cmbStudyDescri.SelectedItem.ToString() + "\t" + cmbTopicDescri.SelectedItem.ToString() + "\t" + dateError.Text);*/
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstErrorLists.Items.Clear();
            StreamReader read = new StreamReader("error.txt");
            String[] field;
            String record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstErrorLists.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4]);

            }
            read.Close();
        }
    }
    
}
