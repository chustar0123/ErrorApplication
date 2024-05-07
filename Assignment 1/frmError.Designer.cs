
namespace Assignment_1
{
    partial class frmError
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
            this.grbErrorDescription = new System.Windows.Forms.GroupBox();
            this.dateError = new System.Windows.Forms.DateTimePicker();
            this.cmbTopicDescri = new System.Windows.Forms.ComboBox();
            this.cmbStudyDescri = new System.Windows.Forms.ComboBox();
            this.txtErrorDescr = new System.Windows.Forms.TextBox();
            this.txtErrorID = new System.Windows.Forms.TextBox();
            this.btnInsertError = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.IbIErrorDate = new System.Windows.Forms.Label();
            this.IbITopicDescription = new System.Windows.Forms.Label();
            this.IbIStudyDescription = new System.Windows.Forms.Label();
            this.IbIErrorDescription = new System.Windows.Forms.Label();
            this.IbIErrorID = new System.Windows.Forms.Label();
            this.grbErrorLists = new System.Windows.Forms.GroupBox();
            this.lstErrorLists = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.grbErrorDescription.SuspendLayout();
            this.grbErrorLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbErrorDescription
            // 
            this.grbErrorDescription.Controls.Add(this.btnList);
            this.grbErrorDescription.Controls.Add(this.dateError);
            this.grbErrorDescription.Controls.Add(this.cmbTopicDescri);
            this.grbErrorDescription.Controls.Add(this.cmbStudyDescri);
            this.grbErrorDescription.Controls.Add(this.txtErrorDescr);
            this.grbErrorDescription.Controls.Add(this.txtErrorID);
            this.grbErrorDescription.Controls.Add(this.btnInsertError);
            this.grbErrorDescription.Controls.Add(this.btnGoHome);
            this.grbErrorDescription.Controls.Add(this.IbIErrorDate);
            this.grbErrorDescription.Controls.Add(this.IbITopicDescription);
            this.grbErrorDescription.Controls.Add(this.IbIStudyDescription);
            this.grbErrorDescription.Controls.Add(this.IbIErrorDescription);
            this.grbErrorDescription.Controls.Add(this.IbIErrorID);
            this.grbErrorDescription.Location = new System.Drawing.Point(12, 12);
            this.grbErrorDescription.Name = "grbErrorDescription";
            this.grbErrorDescription.Size = new System.Drawing.Size(444, 312);
            this.grbErrorDescription.TabIndex = 0;
            this.grbErrorDescription.TabStop = false;
            this.grbErrorDescription.Text = "Error Description";
            // 
            // dateError
            // 
            this.dateError.Location = new System.Drawing.Point(220, 158);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(200, 20);
            this.dateError.TabIndex = 18;
            // 
            // cmbTopicDescri
            // 
            this.cmbTopicDescri.FormattingEnabled = true;
            this.cmbTopicDescri.Location = new System.Drawing.Point(220, 118);
            this.cmbTopicDescri.Name = "cmbTopicDescri";
            this.cmbTopicDescri.Size = new System.Drawing.Size(200, 21);
            this.cmbTopicDescri.TabIndex = 17;
            // 
            // cmbStudyDescri
            // 
            this.cmbStudyDescri.FormattingEnabled = true;
            this.cmbStudyDescri.Location = new System.Drawing.Point(220, 82);
            this.cmbStudyDescri.Name = "cmbStudyDescri";
            this.cmbStudyDescri.Size = new System.Drawing.Size(200, 21);
            this.cmbStudyDescri.TabIndex = 15;
            // 
            // txtErrorDescr
            // 
            this.txtErrorDescr.Location = new System.Drawing.Point(220, 52);
            this.txtErrorDescr.Name = "txtErrorDescr";
            this.txtErrorDescr.Size = new System.Drawing.Size(170, 20);
            this.txtErrorDescr.TabIndex = 14;
            // 
            // txtErrorID
            // 
            this.txtErrorID.Location = new System.Drawing.Point(220, 28);
            this.txtErrorID.Name = "txtErrorID";
            this.txtErrorID.Size = new System.Drawing.Size(170, 20);
            this.txtErrorID.TabIndex = 12;
            // 
            // btnInsertError
            // 
            this.btnInsertError.Location = new System.Drawing.Point(284, 192);
            this.btnInsertError.Name = "btnInsertError";
            this.btnInsertError.Size = new System.Drawing.Size(112, 31);
            this.btnInsertError.TabIndex = 11;
            this.btnInsertError.Text = "Insert Error";
            this.btnInsertError.UseVisualStyleBackColor = true;
            this.btnInsertError.Click += new System.EventHandler(this.btnInsertError_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(155, 192);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(105, 31);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // IbIErrorDate
            // 
            this.IbIErrorDate.AutoSize = true;
            this.IbIErrorDate.Location = new System.Drawing.Point(24, 165);
            this.IbIErrorDate.Name = "IbIErrorDate";
            this.IbIErrorDate.Size = new System.Drawing.Size(58, 13);
            this.IbIErrorDate.TabIndex = 8;
            this.IbIErrorDate.Text = "Error Date:";
            // 
            // IbITopicDescription
            // 
            this.IbITopicDescription.AutoSize = true;
            this.IbITopicDescription.Location = new System.Drawing.Point(24, 126);
            this.IbITopicDescription.Name = "IbITopicDescription";
            this.IbITopicDescription.Size = new System.Drawing.Size(93, 13);
            this.IbITopicDescription.TabIndex = 6;
            this.IbITopicDescription.Text = "Topic Description:";
            // 
            // IbIStudyDescription
            // 
            this.IbIStudyDescription.AutoSize = true;
            this.IbIStudyDescription.Location = new System.Drawing.Point(24, 90);
            this.IbIStudyDescription.Name = "IbIStudyDescription";
            this.IbIStudyDescription.Size = new System.Drawing.Size(93, 13);
            this.IbIStudyDescription.TabIndex = 4;
            this.IbIStudyDescription.Text = "Study Description:";
            // 
            // IbIErrorDescription
            // 
            this.IbIErrorDescription.AutoSize = true;
            this.IbIErrorDescription.Location = new System.Drawing.Point(24, 59);
            this.IbIErrorDescription.Name = "IbIErrorDescription";
            this.IbIErrorDescription.Size = new System.Drawing.Size(88, 13);
            this.IbIErrorDescription.TabIndex = 2;
            this.IbIErrorDescription.Text = "Error Description:";
            // 
            // IbIErrorID
            // 
            this.IbIErrorID.AutoSize = true;
            this.IbIErrorID.Location = new System.Drawing.Point(24, 28);
            this.IbIErrorID.Name = "IbIErrorID";
            this.IbIErrorID.Size = new System.Drawing.Size(46, 13);
            this.IbIErrorID.TabIndex = 0;
            this.IbIErrorID.Text = "Error ID:";
            // 
            // grbErrorLists
            // 
            this.grbErrorLists.Controls.Add(this.lstErrorLists);
            this.grbErrorLists.Location = new System.Drawing.Point(12, 343);
            this.grbErrorLists.Name = "grbErrorLists";
            this.grbErrorLists.Size = new System.Drawing.Size(444, 170);
            this.grbErrorLists.TabIndex = 1;
            this.grbErrorLists.TabStop = false;
            this.grbErrorLists.Text = "Error Lists";
            // 
            // lstErrorLists
            // 
            this.lstErrorLists.FormattingEnabled = true;
            this.lstErrorLists.Location = new System.Drawing.Point(6, 19);
            this.lstErrorLists.Name = "lstErrorLists";
            this.lstErrorLists.Size = new System.Drawing.Size(432, 134);
            this.lstErrorLists.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(284, 251);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(112, 35);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 525);
            this.Controls.Add(this.grbErrorLists);
            this.Controls.Add(this.grbErrorDescription);
            this.Name = "frmError";
            this.Text = "frmError";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.grbErrorDescription.ResumeLayout(false);
            this.grbErrorDescription.PerformLayout();
            this.grbErrorLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbErrorDescription;
        private System.Windows.Forms.DateTimePicker dateError;
        private System.Windows.Forms.ComboBox cmbTopicDescri;
        private System.Windows.Forms.ComboBox cmbStudyDescri;
        private System.Windows.Forms.TextBox txtErrorDescr;
        private System.Windows.Forms.TextBox txtErrorID;
        private System.Windows.Forms.Button btnInsertError;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Label IbIErrorDate;
        private System.Windows.Forms.Label IbITopicDescription;
        private System.Windows.Forms.Label IbIStudyDescription;
        private System.Windows.Forms.Label IbIErrorDescription;
        private System.Windows.Forms.Label IbIErrorID;
        private System.Windows.Forms.GroupBox grbErrorLists;
        private System.Windows.Forms.ListBox lstErrorLists;
        private System.Windows.Forms.Button btnList;
    }
}