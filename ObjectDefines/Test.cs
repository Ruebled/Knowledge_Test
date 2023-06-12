using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDefines
{
    public class Test
    {
        public String Name;
        public Question[] Questions;

        public Test()
        {
            Name = string.Empty;
            Questions = new Question[0];
        }

        public Test(Question[] questions)
        {
            Questions = questions;
        }
    }
}
