using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class UserQuestion
    {
        private string _question;
        private string _answer;
       public string question{
            
            get {
                 return _question;
                }
        } 
       public string answer {
            get
            {
                return _answer;
            }
        }

        public UserQuestion(string question, string answer)
        {
            _question = question;
            _answer = answer;
        }
    }
}
