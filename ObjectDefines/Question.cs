using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDefines
{
    public class Question
    {
        public string name;
        public List<Answer> answers;

        public Question(List<Answer> answers)
        {
            this.answers = answers;
        }

        public Question() 
        {
            answers = new List<Answer>();
        }

        public Question(string name, List<Answer> answers)
        {
            this.name = name;
            this.answers = answers;
        }


    }
}
