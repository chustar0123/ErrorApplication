
namespace Assignment_1
{
    partial class frmErrorSearch
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
            this.grbErrorList = new System.Windows.Forms.GroupBox();
            this.lstErrorList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchError = new System.Windows.Forms.TextBox();
            this.IbISearchError = new System.Windows.Forms.Label();
            this.grbSolution = new System.Windows.Forms.GroupBox();
            this.txtErrorSolutions = new System.Windows.Forms.TextBox();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.grbErrorList.SuspendLayout();
            this.grbSolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbErrorList
            // 
            this.grbErrorList.Controls.Add(this.lstErrorList);
            this.grbErrorList.Controls.Add(this.btnSearch);
            this.grbErrorList.Controls.Add(this.txtSearchError);
            this.grbErrorList.Controls.Add(this.IbISearchError);
            this.grbErrorList.Location = new System.Drawing.Point(12, 12);
            this.grbErrorList.Name = "grbErrorList";
            this.grbErrorList.Size = new System.Drawing.Size(385, 397);
            this.grbErrorList.TabIndex = 0;
            this.grbErrorList.TabStop = false;
            this.grbErrorList.Text = "Error List";
            // 
            // lstErrorList
            // 
            this.lstErrorList.FormattingEnabled = true;
            this.lstErrorList.Location = new System.Drawing.Point(9, 71);
            this.lstErrorList.Name = "lstErrorList";
            this.lstErrorList.Size = new System.Drawing.Size(370, 290);
            this.lstErrorList.TabIndex = 3;
            this.lstErrorList.SelectedIndexChanged += new System.EventHandler(this.lstErrorList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchError
            // 
            this.txtSearchError.Location = new System.Drawing.Point(81, 45);
            this.txtSearchError.Name = "txtSearchError";
            this.txtSearchError.Size = new System.Drawing.Size(201, 20);
            this.txtSearchError.TabIndex = 1;
            // 
            // IbISearchError
            // 
            this.IbISearchError.AutoSize = true;
            this.IbISearchError.Location = new System.Drawing.Point(6, 48);
            this.IbISearchError.Name = "IbISearchError";
            this.IbISearchError.Size = new System.Drawing.Size(69, 13);
            this.IbISearchError.TabIndex = 0;
            this.IbISearchError.Text = "Search Error:";
            // 
            // grbSolution
            // 
            this.grbSolution.Controls.Add(this.txtErrorSolutions);
            this.grbSolution.Controls.Add(this.btnGoHome);
            this.grbSolution.Location = new System.Drawing.Point(429, 12);
            this.grbSolution.Name = "grbSolution";
            this.grbSolution.Size = new System.Drawing.Size(359, 323);
            this.grbSolution.TabIndex = 1;
            this.grbSolution.TabStop = false;
            this.grbSolution.Text = "Solution";
            // 
            // txtErrorSolutions
            // 
            this.txtErrorSolutions.Location = new System.Drawing.Point(6, 41);
            this.txtErrorSolutions.Multiline = true;
            this.txtErrorSolutions.Name = "txtErrorSolutions";
            this.txtErrorSolutions.Size = new System.Drawing.Size(332, 131);
            this.txtErrorSolutions.TabIndex = 1;
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(240, 178);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(98, 31);
            this.btnGoHome.TabIndex = 0;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // frmErrorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSolution);
            this.Controls.Add(this.grbErrorList);
            this.Name = "frmErrorSearch";
            this.Text = "frmErrorSearch";
            this.Load += new System.EventHandler(this.frmErrorSearch_Load);
            this.grbErrorList.ResumeLayout(false);
            this.grbErrorList.PerformLayout();
            this.grbSolution.ResumeLayout(false);
            this.grbSolution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbErrorList;
        private System.Windows.Forms.ListBox lstErrorList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchError;
        private System.Windows.Forms.Label IbISearchError;
        private System.Windows.Forms.GroupBox grbSolution;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.TextBox txtErrorSolutions;
    }
}