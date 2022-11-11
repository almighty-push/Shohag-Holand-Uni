using System;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter number of student: ");
            int numberOfStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //make a arry of student
            Student[] students = new Student[numberOfStudent];
            //take input for name
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.Write($"Enter name of student {i+1}: ");
                string studentName = Console.ReadLine();
                students[i] = new Student(studentName);
            }
            Console.WriteLine();
            //take input for grade
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.Write($"Enter Grade of {students[i].GetStudentName()} : ");
                int studentGrade = Convert.ToInt32(Console.ReadLine());
                students[i].SetStudentGrade(studentGrade);
            }
            Console.WriteLine();

            //find average grade of student
            int sum = 0;
            for (int i = 0; i < numberOfStudent; i++)
            {
                sum += students[i].GetStudentGrade();
            }
            double averageGrade = sum / numberOfStudent;
            Console.WriteLine($"Average grade: {averageGrade}");

            //find highest grade of student
            int highestGrade = students[0].GetStudentGrade();
            string highestGradeStudentName = "";
            for (int i = 0; i < numberOfStudent; i++)
            {
                if (students[i].GetStudentGrade() > highestGrade)
                {
                    highestGrade = students[i].GetStudentGrade();
                    highestGradeStudentName = students[i].GetStudentName();
                }
            }
            Console.WriteLine($"Student {highestGradeStudentName} has highest grade : {highestGrade}");
            Console.WriteLine();
            //print name and grade of student
            for (int i = 0; i < numberOfStudent; i++)
            {
                students[i].PrintNameAndGrade(courseName);
            }
            


        }
    }
}
