using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Student
    {
        //student name and grade
        private readonly string studentName;
        private int studentGrade;
        //constructor
        public Student(string studentName)
        {
            this.studentName = studentName;
        }
        //set student grade
        public void SetStudentGrade(int studentGrade)
        {
            this.studentGrade = studentGrade;
        }
        //get student name
        public string GetStudentName()
        {
            return studentName;
        }
        //get student grade
        public int GetStudentGrade()
        {
            return studentGrade;
        }
        //print name and greade
        public void PrintNameAndGrade(string courseName)
        {
            Console.WriteLine($"Grade for student {studentName} ({courseName}): {studentGrade}");
        }
    }
}
