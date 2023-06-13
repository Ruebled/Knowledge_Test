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
			ID = GenerateID();
            Name = string.Empty;
			Questions = new List<Question>();
        }

		public int GenerateID(){
			var id64Generator = new Id64Generator();

			return id64Generator.GenerateId();

		}

        public Test(string name, List<Question> questions)
        {
			ID = GenerateID();
            Questions = questions;
        }

		public Test(List<string> TestData, string TestFileName_t)
		{
			TestFileName = TestFileName_t;
			
			int i = 0;

			firstLine = TestData[i++];
			string[] ID_Name = firstLine.Trim().Split(TESTS_FILE_DELIM_CORECT);

			ID = Convert.ToInt32(ID_Name[0]);
			Name = Convert.ToInt32(ID_Name[0]);

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

		public string[] ToString()
		{
			string[] Test_to_string = new String[]();

			int i = 0;

			Test_to_string.Add(String.Format("{0}{1}{2}", this.ID, TESTS_FILE_DELIM_CORECT, this.Name));

			foreach(Question question in Questions){
				Test_to_string.Add(question.Name);

				foreach(Answer answer in Answers){
					Test_to_string.Add(string.Format("{0}{1}{2}", answer.correct.ToString(), TESTS_FILE_DELIM_CORECT, answer.text));
				}
				Test_to_string.Add(TESTS_FILE_DELIM_QUESTION);
			}
		}
    }
}
