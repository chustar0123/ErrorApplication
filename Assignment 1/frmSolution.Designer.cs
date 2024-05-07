
namespace Assignment_1
{
    partial class frmSolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSolutionInfo = new System.Windows.Forms.GroupBox();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnInsertSolution = new System.Windows.Forms.Button();
            this.dateError = new System.Windows.Forms.DateTimePicker();
            this.cmbTopicDescr = new System.Windows.Forms.ComboBox();
            this.cmbStudyDescr = new System.Windows.Forms.ComboBox();
            this.cmbErrorDescr = new System.Windows.Forms.ComboBox();
            this.txtSolutionDescription = new System.Windows.Forms.TextBox();
            this.txtErrorID = new System.Windows.Forms.TextBox();
            this.IbISolutionDate = new System.Windows.Forms.Label();
            this.IbITopicDescription = new System.Windows.Forms.Label();
            this.IbIStudyDescription = new System.Windows.Forms.Label();
            this.IbIErrorDescription = new System.Windows.Forms.Label();
            this.IbISolutionDescription = new System.Windows.Forms.Label();
            this.IbIErrorID = new System.Windows.Forms.Label();
            this.grbSolutionLists = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IbINumberOfSolutions = new System.Windows.Forms.Label();
            this.lstSolutionLists = new System.Windows.Forms.ListBox();
            this.btnListError = new System.Windows.Forms.Button();
            this.grbSolutionInfo.SuspendLayout();
            this.grbSolutionLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSolutionInfo
            // 
            this.grbSolutionInfo.Controls.Add(this.btnListError);
            this.grbSolutionInfo.Controls.Add(this.btnGoHome);
            this.grbSolutionInfo.Controls.Add(this.btnInsertSolution);
            this.grbSolutionInfo.Controls.Add(this.dateError);
            this.grbSolutionInfo.Controls.Add(this.cmbTopicDescr);
            this.grbSolutionInfo.Controls.Add(this.cmbStudyDescr);
            this.grbSolutionInfo.Controls.Add(this.cmbErrorDescr);
            this.grbSolutionInfo.Controls.Add(this.txtSolutionDescription);
            this.grbSolutionInfo.Controls.Add(this.txtErrorID);
            this.grbSolutionInfo.Controls.Add(this.IbISolutionDate);
            this.grbSolutionInfo.Controls.Add(this.IbITopicDescription);
            this.grbSolutionInfo.Controls.Add(this.IbIStudyDescription);
            this.grbSolutionInfo.Controls.Add(this.IbIErrorDescription);
            this.grbSolutionInfo.Controls.Add(this.IbISolutionDescription);
            this.grbSolutionInfo.Controls.Add(this.IbIErrorID);
            this.grbSolutionInfo.Location = new System.Drawing.Point(12, 12);
            this.grbSolutionInfo.Name = "grbSolutionInfo";
            this.grbSolutionInfo.Size = new System.Drawing.Size(510, 299);
            this.grbSolutionInfo.TabIndex = 0;
            this.grbSolutionInfo.TabStop = false;
            this.grbSolutionInfo.Text = "Solution Information";
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(169, 218);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(129, 29);
            this.btnGoHome.TabIndex = 22;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnInsertSolution
            // 
            this.btnInsertSolution.Location = new System.Drawing.Point(304, 218);
            this.btnInsertSolution.Name = "btnInsertSolution";
            this.btnInsertSolution.Size = new System.Drawing.Size(136, 29);
            this.btnInsertSolution.TabIndex = 20;
            this.btnInsertSolution.Text = "Insert Solution";
            this.btnInsertSolution.UseVisualStyleBackColor = true;
            this.btnInsertSolution.Click += new System.EventHandler(this.btnInsertSolution_Click);
            // 
            // dateError
            // 
            this.dateError.Location = new System.Drawing.Point(240, 183);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(200, 20);
            this.dateError.TabIndex = 19;
            // 
            // cmbTopicDescr
            // 
            this.cmbTopicDescr.FormattingEnabled = true;
            this.cmbTopicDescr.Location = new System.Drawing.Point(240, 149);
            this.cmbTopicDescr.Name = "cmbTopicDescr";
            this.cmbTopicDescr.Size = new System.Drawing.Size(200, 21);
            this.cmbTopicDescr.TabIndex = 18;
            // 
            // cmbStudyDescr
            // 
            this.cmbStudyDescr.FormattingEnabled = true;
            this.cmbStudyDescr.Location = new System.Drawing.Point(240, 113);
            this.cmbStudyDescr.Name = "cmbStudyDescr";
            this.cmbStudyDescr.Size = new System.Drawing.Size(200, 21);
            this.cmbStudyDescr.TabIndex = 16;
            // 
            // cmbErrorDescr
            // 
            this.cmbErrorDescr.FormattingEnabled = true;
            this.cmbErrorDescr.Location = new System.Drawing.Point(240, 79);
            this.cmbErrorDescr.Name = "cmbErrorDescr";
            this.cmbErrorDescr.Size = new System.Drawing.Size(200, 21);
            this.cmbErrorDescr.TabIndex = 14;
            // 
            // txtSolutionDescription
            // 
            this.txtSolutionDescription.Location = new System.Drawing.Point(240, 53);
            this.txtSolutionDescription.Name = "txtSolutionDescription";
            this.txtSolutionDescription.Size = new System.Drawing.Size(163, 20);
            this.txtSolutionDescription.TabIndex = 13;
            // 
            // txtErrorID
            // 
            this.txtErrorID.Location = new System.Drawing.Point(240, 25);
            this.txtErrorID.Name = "txtErrorID";
            this.txtErrorID.Size = new System.Drawing.Size(163, 20);
            this.txtErrorID.TabIndex = 11;
            // 
            // IbISolutionDate
            // 
            this.IbISolutionDate.AutoSize = true;
            this.IbISolutionDate.Location = new System.Drawing.Point(22, 190);
            this.IbISolutionDate.Name = "IbISolutionDate";
            this.IbISolutionDate.Size = new System.Drawing.Size(74, 13);
            this.IbISolutionDate.TabIndex = 10;
            this.IbISolutionDate.Text = "Solution Date:";
            // 
            // IbITopicDescription
            // 
            this.IbITopicDescription.AutoSize = true;
            this.IbITopicDescription.Location = new System.Drawing.Point(22, 157);
            this.IbITopicDescription.Name = "IbITopicDescription";
            this.IbITopicDescription.Size = new System.Drawing.Size(93, 13);
            this.IbITopicDescription.TabIndex = 8;
            this.IbITopicDescription.Text = "Topic Description:";
            // 
            // IbIStudyDescription
            // 
            this.IbIStudyDescription.AutoSize = true;
            this.IbIStudyDescription.Location = new System.Drawing.Point(22, 121);
            this.IbIStudyDescription.Name = "IbIStudyDescription";
            this.IbIStudyDescription.Size = new System.Drawing.Size(93, 13);
            this.IbIStudyDescription.TabIndex = 6;
            this.IbIStudyDescription.Text = "Study Description:";
            // 
            // IbIErrorDescription
            // 
            this.IbIErrorDescription.AutoSize = true;
            this.IbIErrorDescription.Location = new System.Drawing.Point(22, 87);
            this.IbIErrorDescription.Name = "IbIErrorDescription";
            this.IbIErrorDescription.Size = new System.Drawing.Size(88, 13);
            this.IbIErrorDescription.TabIndex = 4;
            this.IbIErrorDescription.Text = "Error Description:";
            // 
            // IbISolutionDescription
            // 
            this.IbISolutionDescription.AutoSize = true;
            this.IbISolutionDescription.Location = new System.Drawing.Point(22, 53);
            this.IbISolutionDescription.Name = "IbISolutionDescription";
            this.IbISolutionDescription.Size = new System.Drawing.Size(104, 13);
            this.IbISolutionDescription.TabIndex = 2;
            this.IbISolutionDescription.Text = "Solution Description:";
            // 
            // IbIErrorID
            // 
            this.IbIErrorID.AutoSize = true;
            this.IbIErrorID.Location = new System.Drawing.Point(22, 25);
            this.IbIErrorID.Name = "IbIErrorID";
            this.IbIErrorID.Size = new System.Drawing.Size(46, 13);
            this.IbIErrorID.TabIndex = 0;
            this.IbIErrorID.Text = "Error ID:";
            // 
            // grbSolutionLists
            // 
            this.grbSolutionLists.Controls.Add(this.label1);
            this.grbSolutionLists.Controls.Add(this.IbINumberOfSolutions);
            this.grbSolutionLists.Controls.Add(this.lstSolutionLists);
            this.grbSolutionLists.Location = new System.Drawing.Point(10, 317);
            this.grbSolutionLists.Name = "grbSolutionLists";
            this.grbSolutionLists.Size = new System.Drawing.Size(510, 223);
            this.grbSolutionLists.TabIndex = 1;
            this.grbSolutionLists.TabStop = false;
            this.grbSolutionLists.Text = "Solution Lists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Solutions:";
            // 
            // IbINumberOfSolutions
            // 
            this.IbINumberOfSolutions.AutoSize = true;
            this.IbINumberOfSolutions.Location = new System.Drawing.Point(430, 198);
            this.IbINumberOfSolutions.Name = "IbINumberOfSolutions";
            this.IbINumberOfSolutions.Size = new System.Drawing.Size(13, 13);
            this.IbINumberOfSolutions.TabIndex = 3;
            this.IbINumberOfSolutions.Text = "0";
            // 
            // lstSolutionLists
            // 
            this.lstSolutionLists.FormattingEnabled = true;
            this.lstSolutionLists.Location = new System.Drawing.Point(6, 19);
            this.lstSolutionLists.Name = "lstSolutionLists";
            this.lstSolutionLists.Size = new System.Drawing.Size(498, 147);
            this.lstSolutionLists.TabIndex = 0;
            // 
            // btnListError
            // 
            this.btnListError.Location = new System.Drawing.Point(304, 253);
            this.btnListError.Name = "btnListError";
            this.btnListError.Size = new System.Drawing.Size(136, 28);
            this.btnListError.TabIndex = 23;
            this.btnListError.Text = "List";
            this.btnListError.UseVisualStyleBackColor = true;
            this.btnListError.Click += new System.EventHandler(this.btnListError_Click);
            // 
            // frmSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 552);
            this.Controls.Add(this.grbSolutionLists);
            this.Controls.Add(this.grbSolutionInfo);
            this.Name = "frmSolution";
            this.Text = "frmSolution";
            this.Load += new System.EventHandler(this.frmSolution_Load);
            this.grbSolutionInfo.ResumeLayout(false);
            this.grbSolutionInfo.PerformLayout();
            this.grbSolutionLists.ResumeLayout(false);
            this.grbSolutionLists.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSolutionInfo;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Button btnInsertSolution;
        private System.Windows.Forms.DateTimePicker dateError;
        private System.Windows.Forms.ComboBox cmbTopicDescr;
        private System.Windows.Forms.ComboBox cmbStudyDescr;
        private System.Windows.Forms.ComboBox cmbErrorDescr;
        private System.Windows.Forms.TextBox txtSolutionDescription;
        private System.Windows.Forms.TextBox txtErrorID;
        private System.Windows.Forms.Label IbISolutionDate;
        private System.Windows.Forms.Label IbITopicDescription;
        private System.Windows.Forms.Label IbIStudyDescription;
        private System.Windows.Forms.Label IbIErrorDescription;
        private System.Windows.Forms.Label IbISolutionDescription;
        private System.Windows.Forms.Label IbIErrorID;
        private System.Windows.Forms.GroupBox grbSolutionLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IbINumberOfSolutions;
        private System.Windows.Forms.ListBox lstSolutionLists;
        private System.Windows.Forms.Button btnListError;
    }
}