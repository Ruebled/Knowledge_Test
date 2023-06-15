using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministration;
using ObjectDefines;

namespace UI_Forms
{
    public partial class AddTestUI : Form
    {
        Test test_t;
        int currentAddedQuestions;

        public AdminUI AdminUI { get; }

        public AddTestUI()
        {
            InitializeComponent();
        }

        public AddTestUI(AdminUI adminUI)
        {
            AdminUI = adminUI;
            test_t = new Test();
            InitializeComponent();

            currentAddedQuestions = 0;
            //dgvTest.ReadOnly = true;
        }

        private void SaveTest()
        {
            if (test_t != null)
            {
                ManageTests manageTest = new ManageTests();
                manageTest.AddTestToFile(test_t);
            }
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            //Get data for the data from datagridview(dgv)
            if (!ValidateDataGridView())
            {
                return;
            }

            test_t.Name = txtName.Text;

            Question question = null;
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();

            foreach (DataGridViewRow dataGridViewRow in dgvTest.Rows)
            {
                if(dataGridViewRow.Cells[1].Value.ToString().IndexOf("Question") != -1)
                {  
                    if (question != null)
                    {
                        question.answers = answers;
                        questions.Add(question);
                    }

                    question = new Question
                    {
                        name = dataGridViewRow.Cells[2].Value.ToString()
                    };

                    answers = new List<Answer>();
                }
                else if (dataGridViewRow.Cells[1].Value.ToString().IndexOf("Answer") != -1)
                {
                    Answer answer = new Answer
                    {
                        text = dataGridViewRow.Cells[2].Value.ToString(),
                        correct = (bool)dataGridViewRow.Cells[0].Value
                    };

                    answers.Add(answer);
                }
            }

            if (question != null)
            {
                question.answers = answers;
                questions.Add(question);
            }

            test_t.Questions = questions;

            SaveTest();

            this.Close();
            AdminUI.Display();
            AdminUI.Show();
        }

        private bool ValidateDataGridView()
        {
            int ansChecked = 0;

            if(txtName.Text == String.Empty)
            {
                msgErr.Text = "Test name is empty";
                msgErr.ForeColor = Color.Red;
                return false;
            }

            foreach (DataGridViewRow dataGridViewRow in dgvTest.Rows)
            {
                if (dataGridViewRow.Cells[1].Value.ToString().IndexOf("Question") != -1)
                {
                    if(ansChecked == 0 && dataGridViewRow.Index != 0)
                    {
                        msgErr.Text = "A question has no correct answer";
                        msgErr.ForeColor = Color.Red;
                        return false;
                    }

                    ansChecked = 0;

                    if (dataGridViewRow.Cells[2].Value.ToString() == string.Empty)
                    {
                        msgErr.Text = dataGridViewRow.Cells[1].Value.ToString() + " is Empty";
                        msgErr.ForeColor = Color.Red;
                        return false;
                    }
                }
                else if (dataGridViewRow.Cells[1].Value.ToString().IndexOf("Answer") != -1)
                {
                    if (dataGridViewRow.Cells[2].Value.ToString() == string.Empty)
                    {
                        msgErr.Text = "Answer " + " is Empty";
                        msgErr.ForeColor = Color.Red;
                        return false;
                    }

                    if ((bool)dataGridViewRow.Cells[0].Value)
                    {
                        ansChecked++;
                    }
                }
            }
            return true;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            DataGridViewRow questionRow = new DataGridViewRow();

            questionRow.Cells.Add(new DataGridViewTextBoxCell { Value = ""});
            questionRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Format("Question {0}", currentAddedQuestions++ + 1) });
            questionRow.Cells.Add(new DataGridViewTextBoxCell { Value = "" });

            dgvTest.Rows.Add(questionRow);
            //dgvTest.Rows[0].ReadOnly = true;

            int dgvRow = dgvTest.RowCount;
            for (int i = 0; i < dgvRow; i++)
            {
                if (dgvTest.Rows[i].Selected)
                {
                    dgvTest.Rows[i].Selected = false;
                    break;
                }
            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            int dgvRow = dgvTest.RowCount;

            for(int i = 0; i<dgvRow; i++)
            {
                if (dgvTest.Rows[i].Selected)
                {
                    dgvTest.Rows.Insert(i+1, false, "Answer", "");
                }
            }
            
        }
                
        private void dgvTest_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            bool state = false;
            DataGridViewRowCollection rows = dgvTest.Rows;

            foreach (DataGridViewRow row in rows)
            {
                if(row == null)
                {
                    break;
                }

                if (row.Selected)
                {
                    state = true;
                    continue;
                }

                if (state && row.Cells[1].Value.ToString().IndexOf("Question") != -1)
                {
                    break;
                }

                if (state && row.Cells[1].Value.ToString().IndexOf("Answer") != -1)
                {
                    dgvTest.Rows.Remove(row);
                    continue;
                }
                
            }
        }
    }
}
