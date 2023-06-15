using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDefines
{
	
    public class Test
    {
        private const char TESTS_FILE_DELIM_CORECT = ':';
        private const string TESTS_FILE_DELIM_QUESTION = "---";

		public int ID;
		public String TestFileName;
		public String Name;
		public List<Question> Questions;

        public Test()
        {
			ID = GenerateUniqID();
			TestFileName = ID.ToString() + ".txt";
            Name = string.Empty;
			Questions = new List<Question>();
        }

        public Test(Test test_t)
        {
			ID = test_t.ID;
			TestFileName = test_t.TestFileName;
			Name = test_t.Name;
			Questions = new List<Question>();
			
			foreach(Question question in test_t.Questions)
			{
				Question question_t = new Question();
				question_t.name = question.name;

				foreach(Answer answer in question.answers)
				{
					Answer answer_t = new Answer();
					answer_t.text = answer.text;
					answer_t.correct = answer.correct;
					question_t.answers.Add(answer_t);
				}
				Questions.Add(question_t);
			}
        }

        public int GenerateUniqID(){
			var rand = new Random();

			return rand.Next(0, 100000);
		}

        public Test(string name, List<Question> questions)
        {
			ID = GenerateUniqID();
			Name = name;
            Questions = questions;
        }

		public Test(List<string> TestData, string TestFileName_t)
		{
			TestFileName = TestFileName_t;
			
			int i = 0;

            string firstLine = TestData[i++];
			string[] ID_Name = firstLine.Trim().Split(TESTS_FILE_DELIM_CORECT);

			ID = Convert.ToInt32(ID_Name[0]);
			Name = ID_Name[1];

			List<Question> questions_t = new List<Question>();
			Question question_temp = new Question();

			while(true)
			{
				question_temp.name = TestData[i++];	

				while (TestData[i] != TESTS_FILE_DELIM_QUESTION)		
				{
					string[] answer = TestData[i++].Trim().Split(TESTS_FILE_DELIM_CORECT);
					int correct_num = Convert.ToInt32(answer[0]);

					Answer tempAnswer = new Answer(answer[1], correct_num != 0) ;

					question_temp.answers.Add(tempAnswer);
				}
				i++;

				questions_t.Add(question_temp);

				if(i>=TestData.Count){
					break;
				}

                question_temp = new Question();
			}
            this.Questions = questions_t;
        }



        public List<string> ToFileStringConvert()
		{
			List<string> Test_to_string = new List<string>();

			Test_to_string.Add(String.Format("{0}{1}{2}", this.ID, TESTS_FILE_DELIM_CORECT, this.Name));

			foreach(Question question in Questions){
				Test_to_string.Add(question.name);

				foreach(Answer answer in question.answers){
					Test_to_string.Add(string.Format("{0}{1}{2}", Convert.ToInt32(answer.correct).ToString(), TESTS_FILE_DELIM_CORECT, answer.text));
				}
				Test_to_string.Add(TESTS_FILE_DELIM_QUESTION);
			}
			return Test_to_string;
		}
    }
}
