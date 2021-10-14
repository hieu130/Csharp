using System;
using System.Reflection;

namespace Demo.Models
{
    public class Student
    {
        public string RollNumber  { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set;}
        public string Phone { get; set; }
        public DateTime CreateAt { get; set; }
        public StudentStatus Status { get; set; }
        public override string ToString()
        {
            return $"Rollnumber{RollNumber},Fullname{FullName},Email{Email},Birthday{Birthday},Phone{Phone},Status{Status},Datetime{CreateAt}";
        }

    }
}