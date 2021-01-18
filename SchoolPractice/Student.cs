using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        public Student(int numberOfCredits, double gpa, string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(int numberOfCredits, double gpa, string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }


        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public override string ToString()
        {
            return $"{Name}\nCredits: {NumberOfCredits}\nGPA: {Gpa}";
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double score = Gpa * NumberOfCredits;
            score += courseCredits * grade;
            NumberOfCredits += NumberOfCredits + courseCredits;
            Gpa = courseCredits * grade / NumberOfCredits;
            Gpa = score / NumberOfCredits;
            // Update the appropriate fields: NumberOfCredits, Gpa

        }

        public string GetGradeLevel()
        {

            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (NumberOfCredits < 60 && NumberOfCredits > 29)
            {
                return "Sophmore";
            }
            else if (NumberOfCredits < 90 && NumberOfCredits > 59)
            {
                return "Junior";
            }
            else if (NumberOfCredits > 89)
            {
                return "Senior";
            }
            else
            {
                return "Error";
            }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student other = obj as Student;
            return this.studentId == other.studentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(studentId);
        }

        
    }
}