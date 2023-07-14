using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    public class Student1
    {
        private int age;
        public void AcceptDetails(int age)
        {
            if (age>18)
            {
                throw new AgeException(" age is not valid");
            }
            else
            {
                this.age = age;
            }
        }
    }
}
