using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp1
{
    public class User:IComparable
    {
        public string firstName;
        public string lastName;
        public int yearOfBirth;
        public  string email;

        public User(string firstName, string lastName, int yearOfBirth, string email)
        {
            this.firstName=firstName;
            this.lastName=lastName;
            this.yearOfBirth = yearOfBirth;
            this.email=email;

        }
        public void  ToString()
        {
            Console.WriteLine($"{this.firstName}  {this.lastName}    {this.yearOfBirth}   {this.email}");
        }



        public int CompareTo(object obj) 
        {
            User p = (User)obj; 
            if (this.yearOfBirth < p.yearOfBirth) return 1;
            if (this.yearOfBirth > p.yearOfBirth) return -1;
            return 0; 
        }
    }
}
