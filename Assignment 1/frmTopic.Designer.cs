
namespace Assignment_1
{
    partial class frmTopic
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
            this.grbTopics = new System.Windows.Forms.GroupBox();
            this.btnInsertTopic = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.cmbStudyDescrip = new System.Windows.Forms.ComboBox();
            this.txtbxTopicDescrip = new System.Windows.Forms.TextBox();
            this.txtbxTopicID = new System.Windows.Forms.TextBox();
            this.IbIStudyDescription = new System.Windows.Forms.Label();
            this.IbITopicDescrption = new System.Windows.Forms.Label();
            this.IbITopicID = new System.Windows.Forms.Label();
            this.grTopicLists = new System.Windows.Forms.GroupBox();
            this.lstbxTopicList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbTopics.SuspendLayout();
            this.grTopicLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTopics
            // 
            this.grbTopics.Controls.Add(this.button1);
            this.grbTopics.Controls.Add(this.btnInsertTopic);
            this.grbTopics.Controls.Add(this.btnGoHome);
            this.grbTopics.Controls.Add(this.cmbStudyDescrip);
            this.grbTopics.Controls.Add(this.txtbxTopicDescrip);
            this.grbTopics.Controls.Add(this.txtbxTopicID);
            this.grbTopics.Controls.Add(this.IbIStudyDescription);
            this.grbTopics.Controls.Add(this.IbITopicDescrption);
            this.grbTopics.Controls.Add(this.IbITopicID);
            this.grbTopics.Location = new System.Drawing.Point(3, 12);
            this.grbTopics.Name = "grbTopics";
            this.grbTopics.Size = new System.Drawing.Size(434, 242);
            this.grbTopics.TabIndex = 0;
            this.grbTopics.TabStop = false;
            this.grbTopics.Text = "Topics";
            // 
            // btnInsertTopic
            // 
            this.btnInsertTopic.Location = new System.Drawing.Point(260, 145);
            this.btnInsertTopic.Name = "btnInsertTopic";
            this.btnInsertTopic.Size = new System.Drawing.Size(120, 36);
            this.btnInsertTopic.TabIndex = 11;
            this.btnInsertTopic.Text = "Insert Topic";
            this.btnInsertTopic.UseVisualStyleBackColor = true;
            this.btnInsertTopic.Click += new System.EventHandler(this.btnInsertTopic_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(135, 145);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(119, 36);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // cmbStudyDescrip
            // 
            this.cmbStudyDescrip.FormattingEnabled = true;
            this.cmbStudyDescrip.Location = new System.Drawing.Point(196, 118);
            this.cmbStudyDescrip.Name = "cmbStudyDescrip";
            this.cmbStudyDescrip.Size = new System.Drawing.Size(184, 21);
            this.cmbStudyDescrip.TabIndex = 8;
            // 
            // txtbxTopicDescrip
            // 
            this.txtbxTopicDescrip.Location = new System.Drawing.Point(196, 75);
            this.txtbxTopicDescrip.Name = "txtbxTopicDescrip";
            this.txtbxTopicDescrip.Size = new System.Drawing.Size(146, 20);
            this.txtbxTopicDescrip.TabIndex = 7;
            // 
            // txtbxTopicID
            // 
            this.txtbxTopicID.Location = new System.Drawing.Point(196, 35);
            this.txtbxTopicID.Name = "txtbxTopicID";
            this.txtbxTopicID.Size = new System.Drawing.Size(146, 20);
            this.txtbxTopicID.TabIndex = 5;
            // 
            // IbIStudyDescription
            // 
            this.IbIStudyDescription.AutoSize = true;
            this.IbIStudyDescription.Location = new System.Drawing.Point(29, 118);
            this.IbIStudyDescription.Name = "IbIStudyDescription";
            this.IbIStudyDescription.Size = new System.Drawing.Size(93, 13);
            this.IbIStudyDescription.TabIndex = 4;
            this.IbIStudyDescription.Text = "Study Description:";
            // 
            // IbITopicDescrption
            // 
            this.IbITopicDescrption.AutoSize = true;
            this.IbITopicDescrption.Location = new System.Drawing.Point(29, 75);
            this.IbITopicDescrption.Name = "IbITopicDescrption";
            this.IbITopicDescrption.Size = new System.Drawing.Size(93, 13);
            this.IbITopicDescrption.TabIndex = 2;
            this.IbITopicDescrption.Text = "Topic Description:";
            // 
            // IbITopicID
            // 
            this.IbITopicID.AutoSize = true;
            this.IbITopicID.Location = new System.Drawing.Point(29, 38);
            this.IbITopicID.Name = "IbITopicID";
            this.IbITopicID.Size = new System.Drawing.Size(51, 13);
            this.IbITopicID.TabIndex = 0;
            this.IbITopicID.Text = "Topic ID:";
            // 
            // grTopicLists
            // 
            this.grTopicLists.Controls.Add(this.lstbxTopicList);
            this.grTopicLists.Location = new System.Drawing.Point(3, 260);
            this.grTopicLists.Name = "grTopicLists";
            this.grTopicLists.Size = new System.Drawing.Size(431, 230);
            this.grTopicLists.TabIndex = 1;
            this.grTopicLists.TabStop = false;
            this.grTopicLists.Text = "Topic Lists";
            // 
            // lstbxTopicList
            // 
            this.lstbxTopicList.FormattingEnabled = true;
            this.lstbxTopicList.Location = new System.Drawing.Point(6, 28);
            this.lstbxTopicList.Name = "lstbxTopicList";
            this.lstbxTopicList.Size = new System.Drawing.Size(416, 199);
            this.lstbxTopicList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 502);
            this.Controls.Add(this.grTopicLists);
            this.Controls.Add(this.grbTopics);
            this.Name = "frmTopic";
            this.Text = "frmTopic";
            this.Load += new System.EventHandler(this.frmTopic_Load);
            this.grbTopics.ResumeLayout(false);
            this.grbTopics.PerformLayout();
            this.grTopicLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTopics;
        private System.Windows.Forms.Button btnInsertTopic;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.ComboBox cmbStudyDescrip;
        private System.Windows.Forms.TextBox txtbxTopicDescrip;
        private System.Windows.Forms.TextBox txtbxTopicID;
        private System.Windows.Forms.Label IbIStudyDescription;
        private System.Windows.Forms.Label IbITopicDescrption;
        private System.Windows.Forms.Label IbITopicID;
        private System.Windows.Forms.GroupBox grTopicLists;
        private System.Windows.Forms.ListBox lstbxTopicList;
        private System.Windows.Forms.Button button1;
    }
}