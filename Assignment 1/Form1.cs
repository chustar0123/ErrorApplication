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
    public partial class frmStudy : Form
    {
        public frmStudy()
        {
            InitializeComponent();
        }
        int count = 100000;
        
 
        private void btnInsertYear_Click(object sender, EventArgs e)
        {
            txtStudyID.Text = count.ToString();
            txtStudyID.Enabled = false;
            count = int.Parse(txtStudyID.Text);
            count++;

            /*lstStudy.Items.Add(txtStudyID.Text + "\t" + txtStudyDesc.Text);*/
            StreamWriter writeStudyYear = new StreamWriter("Study.txt", true);

            writeStudyYear.WriteLine(txtStudyID.Text + "#" + txtStudyDesc.Text);
            writeStudyYear.Close();



            txtStudyDesc.Clear();

        }
        

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmLanding form = new frmLanding();
            form.Show();
            this.Hide();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
   

            lstStudy.Items.Clear();
            StreamReader read = new StreamReader("Study.txt");
            String[] field;
            String record = "";
            while((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstStudy.Items.Add(field[0] + "\t" + field[1]);

            }
            read.Close();
        }
    }

}
