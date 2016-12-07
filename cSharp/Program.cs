using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //this is singleton
            Student student = Student.GetStudentInstance();
            student.Name = "One";
            Console.WriteLine(student.Name);
            student.Name = "Two";
            Console.WriteLine(student.Name);
           

            //readonly can change value during runtime
            Variable va = new Variable();
            Variable va1 = new Variable("Changed");
            
        }

    }

   public class Student
    {
        public string Name;
        static Student student = null;
        private Student() { }

        public static Student GetStudentInstance()
        {
            if(student == null)
            {
                student = new Student();
                return student;
            }
            return student;
        }
       
    }

    public class Variable
    {
        readonly string re = "Hien";


        public Variable()
        {
            re = "This readony string has been changed during runtime";
            Console.WriteLine(re);
        }

        public Variable(string variable)
        {
            re = variable + "This readony string has been changed during runtime";
            Console.WriteLine(re);
        }
    }
}
