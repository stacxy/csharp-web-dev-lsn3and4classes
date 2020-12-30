using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student Stacey = new Student(1, 4.0, "Stacey");

            Course Math = new Course("Math")
            {
                Instructor = new Teacher("A", "Teacher", "Math", 2)
            };

            Math.Roster.Add(Stacey);
            Console.WriteLine(Stacey.GetGradeLevel());
            Console.WriteLine(Stacey.ToString());

           
           
        }
    }
}
