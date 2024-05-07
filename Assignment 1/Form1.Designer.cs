
namespace Assignment_1
{
    partial class frmStudy
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
            this.grbStudyLevel = new System.Windows.Forms.GroupBox();
            this.btnInsertYear = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.lstStudy = new System.Windows.Forms.ListBox();
            this.txtStudyDesc = new System.Windows.Forms.TextBox();
            this.txtStudyID = new System.Windows.Forms.TextBox();
            this.IbIStudyDescription = new System.Windows.Forms.Label();
            this.IbIStudyID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbStudyLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStudyLevel
            // 
            this.grbStudyLevel.Controls.Add(this.button1);
            this.grbStudyLevel.Controls.Add(this.btnInsertYear);
            this.grbStudyLevel.Controls.Add(this.btnGoHome);
            this.grbStudyLevel.Controls.Add(this.lstStudy);
            this.grbStudyLevel.Controls.Add(this.txtStudyDesc);
            this.grbStudyLevel.Controls.Add(this.txtStudyID);
            this.grbStudyLevel.Controls.Add(this.IbIStudyDescription);
            this.grbStudyLevel.Controls.Add(this.IbIStudyID);
            this.grbStudyLevel.Location = new System.Drawing.Point(12, 12);
            this.grbStudyLevel.Name = "grbStudyLevel";
            this.grbStudyLevel.Size = new System.Drawing.Size(741, 300);
            this.grbStudyLevel.TabIndex = 0;
            this.grbStudyLevel.TabStop = false;
            this.grbStudyLevel.Text = "Study Level Information";
            // 
            // btnInsertYear
            // 
            this.btnInsertYear.Location = new System.Drawing.Point(208, 127);
            this.btnInsertYear.Name = "btnInsertYear";
            this.btnInsertYear.Size = new System.Drawing.Size(126, 33);
            this.btnInsertYear.TabIndex = 9;
            this.btnInsertYear.Text = "Insert Year";
            this.btnInsertYear.UseVisualStyleBackColor = true;
            this.btnInsertYear.Click += new System.EventHandler(this.btnInsertYear_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(68, 127);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(134, 33);
            this.btnGoHome.TabIndex = 7;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // lstStudy
            // 
            this.lstStudy.FormattingEnabled = true;
            this.lstStudy.Location = new System.Drawing.Point(340, 55);
            this.lstStudy.Name = "lstStudy";
            this.lstStudy.Size = new System.Drawing.Size(393, 186);
            this.lstStudy.TabIndex = 6;
            // 
            // txtStudyDesc
            // 
            this.txtStudyDesc.Location = new System.Drawing.Point(120, 89);
            this.txtStudyDesc.Name = "txtStudyDesc";
            this.txtStudyDesc.Size = new System.Drawing.Size(214, 20);
            this.txtStudyDesc.TabIndex = 5;
            // 
            // txtStudyID
            // 
            this.txtStudyID.Location = new System.Drawing.Point(120, 55);
            this.txtStudyID.Name = "txtStudyID";
            this.txtStudyID.Size = new System.Drawing.Size(214, 20);
            this.txtStudyID.TabIndex = 3;
            // 
            // IbIStudyDescription
            // 
            this.IbIStudyDescription.AutoSize = true;
            this.IbIStudyDescription.Location = new System.Drawing.Point(6, 96);
            this.IbIStudyDescription.Name = "IbIStudyDescription";
            this.IbIStudyDescription.Size = new System.Drawing.Size(93, 13);
            this.IbIStudyDescription.TabIndex = 2;
            this.IbIStudyDescription.Text = "Study Description:";
            // 
            // IbIStudyID
            // 
            this.IbIStudyID.AutoSize = true;
            this.IbIStudyID.Location = new System.Drawing.Point(6, 55);
            this.IbIStudyID.Name = "IbIStudyID";
            this.IbIStudyID.Size = new System.Drawing.Size(51, 13);
            this.IbIStudyID.TabIndex = 0;
            this.IbIStudyID.Text = "Study ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 322);
            this.Controls.Add(this.grbStudyLevel);
            this.Name = "frmStudy";
            this.Text = "frmStudy";
            this.grbStudyLevel.ResumeLayout(false);
            this.grbStudyLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudyLevel;
        private System.Windows.Forms.Button btnInsertYear;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.ListBox lstStudy;
        private System.Windows.Forms.TextBox txtStudyDesc;
        private System.Windows.Forms.TextBox txtStudyID;
        private System.Windows.Forms.Label IbIStudyDescription;
        private System.Windows.Forms.Label IbIStudyID;
        private System.Windows.Forms.Button button1;
    }
}

