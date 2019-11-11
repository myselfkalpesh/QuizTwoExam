using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTwoExam
{
    class User
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string tel { get; set; }
        

        public User(string fName, string lName, string tel)
        {
            this.fName = fName;
            this.lName = lName;
            this.tel = tel;
        }

        public override string ToString()
        {
            return $"[First Name: {this.fName}, Last Name: {this.lName}, Telephone: {this.tel}],\n";
        }
    }
}
