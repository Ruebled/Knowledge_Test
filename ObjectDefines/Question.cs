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
        public Answer[] answers;

        public Question() 
        {
            answers = new Answer[0];
        }

        public Question(string name, Answer[] answers)
        {
            this.name = name;
            this.answers = answers;
        }


    }
}
