namespace UI_Forms
{
    partial class StudUI
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewTests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(2, 26);
            this.lblEmail.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Location = new System.Drawing.Point(12, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(2, 26);
            this.lblName.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(292, 71);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(533, 32);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1090, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 28);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(870, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 37);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewTests
            // 
            this.listViewTests.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listViewTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTests.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTests.FormattingEnabled = true;
            this.listViewTests.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listViewTests.ItemHeight = 40;
            this.listViewTests.Location = new System.Drawing.Point(249, 161);
            this.listViewTests.Margin = new System.Windows.Forms.Padding(10);
            this.listViewTests.MaximumSize = new System.Drawing.Size(757, 360);
            this.listViewTests.MinimumSize = new System.Drawing.Size(757, 360);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(757, 360);
            this.listViewTests.TabIndex = 10;
            this.listViewTests.SelectedIndexChanged += new System.EventHandler(this.listViewTests_SelectedIndexChanged);
            // 
            // StudUI
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 574);
            this.ControlBox = false;
            this.Controls.Add(this.listViewTests);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1184, 574);
            this.MinimumSize = new System.Drawing.Size(1184, 574);
            this.Name = "StudUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listViewTests;
    }
}