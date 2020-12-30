using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public byte YearsTeaching { get; set; }
    
        public Teacher(string firstName, string lastname, string subject, byte yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
    
   
}

   
