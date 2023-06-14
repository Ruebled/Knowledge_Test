namespace UI_Forms
{
    partial class AdminUI
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(870, 68);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 37);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(292, 71);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(533, 32);
            this.txtQuery.TabIndex = 12;
            this.txtQuery.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 9);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 24);
            this.lblEmail.TabIndex = 9;
            // 
            // lstBox
            // 
            this.lstBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lstBox.ItemHeight = 40;
            this.lstBox.Location = new System.Drawing.Point(249, 161);
            this.lstBox.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(757, 360);
            this.lstBox.TabIndex = 16;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1089, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 28);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(523, 9);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(83, 35);
            this.lblEdit.TabIndex = 18;
            this.lblEdit.Text = "label1";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTest.Location = new System.Drawing.Point(960, 68);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(100, 37);
            this.btnAddTest.TabIndex = 19;
            this.btnAddTest.Text = "ADD TEST";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 574);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label btnLogout;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnAddTest;
    }
}