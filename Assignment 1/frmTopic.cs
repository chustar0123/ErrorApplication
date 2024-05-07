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
    public partial class frmTopic : Form
    {
        public frmTopic()
        {
            InitializeComponent();
        }
        int topicID = 10000;
        private void btnInsertTopic_Click(object sender, EventArgs e)
        {
            txtbxTopicID.Text = topicID.ToString();
            txtbxTopicID.Enabled = false;
            topicID = int.Parse(txtbxTopicID.Text);
            topicID++;
            StreamWriter writeTopics = new StreamWriter("Topic.txt", true);
            writeTopics.WriteLine(txtbxTopicID.Text + "#" + txtbxTopicDescrip.Text + "#" + cmbStudyDescrip.SelectedItem.ToString());
            writeTopics.Close();

            /*lstbxTopicList.Items.Add(txtbxTopicID.Text + "\t" + cmbStudyDescrip.SelectedItem + "\t" + txtbxTopicDescrip.Text);*/

        }
        
        private void frmTopic_Load(object sender, EventArgs e)
        {
            

            string[] field;
            StreamReader readStudyYear = new StreamReader("Study.txt");
            string record = "";
            while ((record = readStudyYear.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbStudyDescrip.Items.Add(field[1]);
            }

            readStudyYear.Close();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmLanding form = new frmLanding();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstbxTopicList.Items.Clear();
            StreamReader read = new StreamReader("Topic.txt");
            String[] field;
            String record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstbxTopicList.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2]);

            }
            read.Close();
        }
    }
}
