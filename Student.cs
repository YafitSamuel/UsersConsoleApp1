using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp1
{
    public class Student : User
    {
        string class_;
        public Student(string firstName, string lastName, int yearOfBirth, string email, string class_) : base(firstName, lastName, yearOfBirth, email)
        {
            this.class_ = class_;
        }

        public void Tostring()
        {
            base.ToString();
            Console.WriteLine(this.class_);

        }

    }


}
