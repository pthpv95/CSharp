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
            Student student = Student.GetStudentInstance();
            student.Name = "One";
            Console.WriteLine(student.Name);
            student.Name = "Two";
            Console.WriteLine(student.Name);
            //this is singleton
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
}
