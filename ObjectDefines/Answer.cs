using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDefines
{
    public class Answer
    {
        public string text;
        public bool correct;
        public Answer() { }  
        
        public Answer(string text_v, bool correct_v) { 
            this.text = text_v;
            this.correct = correct_v;
        }
    }
}
