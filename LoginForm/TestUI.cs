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

        public TestUI()
        {
            InitializeComponent();
        }

        public TestUI(Test test_t, StudUI studUI)
        {
            test = test_t;
            StudUI = studUI;

            test_in_progress = test_t;
           
            null_test_list();

            InitializeComponent();

            studUI.Hide();

            score = 0;
            total = 0;
            currentQuestionIndex = 0;
            RedrawQuestion();
        }

        public void null_test_list()
        {
            int question_cnt = 0;
            foreach(Question question in test_in_progress.Questions)
            {
                int answer_cnt = 0;
                foreach(Answer answer in question.answers)
                {
                    test_in_progress.Questions[question_cnt].answers[answer_cnt].correct = false;
                    answer_cnt++;
                }
                question_cnt = 0;
            }
        }

        public void RedrawQuestion()
        {
            lblQuestion.Text = test.Questions[currentQuestionIndex].name;

            ckbList.Items.Clear();

            foreach(Answer answer in test.Questions[currentQuestionIndex].answers)
            {
                ckbList.Items.Add(answer.text);
            }
        }

        public Test test { get; }
        public StudUI StudUI { get; }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void listViewAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

            test_in_progress.Questions[currentQuestionIndex].answers[selected_index].correct = selected_state;
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

            string mesaj_scor = string.Format("Answered {0}/{1}", this.score, this.total);

            var confirmResult = MessageBox.Show(mesaj_scor, "Confirm!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                StudUI.Show();
            }
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
