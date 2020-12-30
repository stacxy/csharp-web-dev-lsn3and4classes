using System;
using System.Collections.Generic;

namespace SchoolPractice
{
	public class Course
	{
		public string Subject { get; set; }
		public int CourseCredits { get; set; } 

		public Teacher Instructor { get; set; }

		public List<Student> Roster {get; set;}

		public Course(string subject)
        {
			Subject = subject;
			CourseCredits = 1;
			Roster = new List<Student>();
        }
			
			
		
		//public double Grade { get; set; }


		
	}
}
