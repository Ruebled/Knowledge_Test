using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectDefines;

namespace UI_Forms
{

    public partial class TestUI : Form
    {
        int currentQuestionIndex;

        int score;
        int total;

        Test test_in_progress = new Test();
        private AdminUI adminUI;

        public TestUI()
        {
            InitializeComponent();

            if (currentQuestionIndex == 0)
            {
                btnPrev.Enabled = false;
            }

            if (currentQuestionIndex == test.Questions.Count - 1)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
        }

        public TestUI(Test test_t, StudUI studUI)
        {
            test = test_t;
            StudUI = studUI;

            test_in_progress = new Test(test_t);
           
            null_test_list();

            InitializeComponent();

            studUI.Hide();

            score = 0;
            total = 0;
            currentQuestionIndex = 0;
            RedrawQuestion();


            if (currentQuestionIndex == 0)
            {
                btnPrev.Enabled = false;
            }

            if (currentQuestionIndex == test.Questions.Count - 1)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
        }

        public TestUI(Test test_t, AdminUI adminUI)
        {
            this.test = test_t;
            this.adminUI = adminUI;;

            test_in_progress = new Test(test_t);

            null_test_list();

            InitializeComponent();

            adminUI.Hide();

            score = 0;
            total = 0;
            currentQuestionIndex = 0;
            RedrawQuestion();


            if (currentQuestionIndex == 0)
            {
                btnPrev.Enabled = false;
            }

            if (currentQuestionIndex == test_t.Questions.Count - 1)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
        }

        public void null_test_list()
        {
       
            foreach(Question question in test_in_progress.Questions)
            {
                
                foreach(Answer answer in question.answers)
                {
                    answer.correct = false;

                }
           
            }
        }

        public void RedrawQuestion()
        {
            lblQuestion.Text = test_in_progress.Questions[currentQuestionIndex].name;

            ckbList.Items.Clear();

            int i = 0;

            foreach(Answer answer in test_in_progress.Questions[currentQuestionIndex].answers)
            {
                
                ckbList.Items.Add(answer.text);
                ckbList.SetItemChecked(i++, answer.correct);
            }
        }

        public Test test { get; }
        public StudUI StudUI { get; }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentQuestionIndex--;

            btnNext.Enabled = true;

            if(currentQuestionIndex == 0)
            {
                btnPrev.Enabled = false;
            }

            RedrawQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;

            btnPrev.Enabled = true;

            if (currentQuestionIndex == test.Questions.Count-1)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }

            RedrawQuestion();
        }

        private void ckbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = ckbList.SelectedIndex;
            bool selected_state = ckbList.GetItemChecked(selected_index);

            ckbList.SetItemChecked(selected_index, !selected_state);

            test_in_progress.Questions[currentQuestionIndex].answers[selected_index].correct = !selected_state;

            //ckbList.SelectedIndex = 0;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.score = 0;
            this.total = 0;

            for(int i=0; i<test.Questions.Count; i++)
            {
                bool state = true;

                for(int j=0; j < test.Questions[i].answers.Count; j++)
                {
                    if (test_in_progress.Questions[i].answers[j].correct != test.Questions[i].answers[j].correct)
                    {
                        state = false;
                    }
                }
                if (state == true)
                {
                    this.score++;
                }
                this.total++;
            }

            //Change score in user for this test
            ResultUI resultui;

            if (adminUI != null)
            {
                resultui = new ResultUI(string.Format("Score {0}/{1}", this.score, this.total), adminUI);
            }
            else
            {
                resultui = new ResultUI(string.Format("Score {0}/{1}", this.score, this.total), StudUI);
            }
           
            resultui.Show();
            this.Close();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wanna exit the test?", "Confirm Exit!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                StudUI.Show();
            }
            return;
        }
    }
}
