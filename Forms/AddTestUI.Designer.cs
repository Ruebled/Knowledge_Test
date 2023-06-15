namespace UI_Forms
{
    partial class AddTestUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.ckbColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(572, 32);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEST NAME";
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTest.Location = new System.Drawing.Point(475, 479);
            this.btnSaveTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(108, 37);
            this.btnSaveTest.TabIndex = 18;
            this.btnSaveTest.Text = "SAVE TEST";
            this.btnSaveTest.UseVisualStyleBackColor = false;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddQuestion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(16, 478);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(157, 37);
            this.btnAddQuestion.TabIndex = 19;
            this.btnAddQuestion.Text = "ADD QUESTION";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToResizeColumns = false;
            this.dgvTest.AllowUserToResizeRows = false;
            this.dgvTest.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckbColumn,
            this.Column1,
            this.Column2});
            this.dgvTest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvTest.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTest.Location = new System.Drawing.Point(12, 75);
            this.dgvTest.MultiSelect = false;
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowHeadersVisible = false;
            this.dgvTest.RowHeadersWidth = 51;
            this.dgvTest.RowTemplate.Height = 24;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(572, 396);
            this.dgvTest.TabIndex = 22;
            this.dgvTest.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTest_UserDeletingRow);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddAnswer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnswer.Location = new System.Drawing.Point(181, 478);
            this.btnAddAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(157, 37);
            this.btnAddAnswer.TabIndex = 23;
            this.btnAddAnswer.Text = "ADD ANSWER";
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // ckbColumn
            // 
            this.ckbColumn.HeaderText = "";
            this.ckbColumn.MinimumWidth = 6;
            this.ckbColumn.Name = "ckbColumn";
            this.ckbColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ckbColumn.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "What is this";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 500F;
            this.Column2.HeaderText = "Data";
            this.Column2.MaxInputLength = 150;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 410;
            // 
            // msgErr
            // 
            this.msgErr.AutoSize = true;
            this.msgErr.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErr.Location = new System.Drawing.Point(134, 12);
            this.msgErr.Name = "msgErr";
            this.msgErr.Size = new System.Drawing.Size(0, 22);
            this.msgErr.TabIndex = 24;
            // 
            // AddTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(596, 528);
            this.Controls.Add(this.msgErr);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTest";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckbColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label msgErr;
    }
}