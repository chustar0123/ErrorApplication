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
    public partial class frmErrorSearch : Form
    {
        public frmErrorSearch()
        {
            InitializeComponent();
        }
        private void lstErrorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            StreamReader solutionReader = new StreamReader("Solution.txt");
            string[] field;
            string record = "";
            
            while ((record = solutionReader.ReadLine()) != null)
            {
               
                field = record.Split('#');
               
                if(lstErrorList.SelectedItem.ToString() == field[2])
                {
                    txtErrorSolutions.Text = field[1];
                    break;
                }
                else
                {
                    txtErrorSolutions.Text = "Solution is not found";
                }

            }
            solutionReader.Close();


        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmLanding form = new frmLanding();
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader solutionReader = new StreamReader("Solution.txt");
            string[] field;
            string record = "";

            while((record = solutionReader.ReadLine()) != null)
            {
                field = record.Split('#');
                lstErrorList.Items.Add(txtSearchError.Text);
                break;
            }
            solutionReader.Close();

        }

        private void frmErrorSearch_Load(object sender, EventArgs e)
        {
            StreamReader errorReader = new StreamReader("error.txt");
            string[] read;
            string ErrorRecord = "";
            while ((ErrorRecord = errorReader.ReadLine()) != null)
            {
                read = ErrorRecord.Split('#');
                lstErrorList.Items.Add(read[1]);
                

            }
            errorReader.Close();
        }
    }
}
