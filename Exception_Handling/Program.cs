using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //try
            //{
            //    s.AcceptDetails("",20);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Student1 stud = new Student1();
            try
            {
                stud.AcceptDetails( 19);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
