using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDefines
{
	private const char TESTS_FILE_DELIM_CORECT = ':';
	private const string TESTS_FILE_DELIM_QUESTION = "---";
	private const string TESTS_FILE_DELIM_TESTS = "===";

    public class Test
    {
		public String TestFileName { get; set; }
        public String Name { get; set; }
        public Question[] Questions { get; set; }

        public Test()
        {
            Name = string.Empty;
            Questions = new Question[0];
        }

        public Test(Question[] questions)
        {
            Questions = questions;
        }

		public Test(string[] TestData, string TestFileName_t)
		{
			TestFileName = TestFileName_t;

			//TestName
			//question1
			//1:answer1
			//0:answer2
			//0:answer4
			//1:answer3
			//---
			//question2
			//1:answer1
			//0:answer2
			//0:answer4
			//1:answer3
			//---

			
			int i = 0;

			Name = TestData[i++];

			Question question_temp = new Question();

			while(true)
			{
				question_temp.name = TestData[i++];	

				while (TestData[i] != TESTS_FILE_DELIM_QUESTION)		
				{
					string[] answer = TestData[i++].Trim().Split(TESTS_FILE_DELIM_CORECT);
					int correct_num = Convert.ToInt32(answer[0]);
					
					Answer tempAnswer = new Answer(answer[1], (bool)correct_num);

					question_temp.answers.Add(tempAnswer);
				}

				Questions.Add(question_temp);

				if(i>=TestData.Length){
					break;
				}

				question_temp = new Question();
			}
		}
    }
}
