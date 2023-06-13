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
		//private const string TESTS_FILE_DELIM_TESTS = "===";


		public String TestFileName;
		public String Name;
		public List<Question> Questions;

        public Test()
        {
            Name = string.Empty;
			Questions = new List<Question>();
        }

        public Test(List<Question> questions)
        {
            Questions = questions;
        }

		public Test(List<string> TestData, string TestFileName_t)
		{
			TestFileName = TestFileName_t;
			
			int i = 0;

			Name = TestData[i++];

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

				

                //questions_t = new List<Question>();
                question_temp = new Question();
			}
            this.Questions = questions_t;
        }
    }
}
