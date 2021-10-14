using System;
using System.Reflection;

namespace Demo.Models
{
    public class Student
    {
        public  string RollNumber  { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set;}
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }

        public bool IsNewStudent()
        {
            /*var thoiGianNhapHoc = CreateAt;
            var thGianHienTai = DateTime.Now;
            if (thoiGianNhapHoc.AddMonths(2).CompareTo(thGianHienTai) <=0)
            {
                return true;
            }

            return false;*/
            return DateTime.Now.CompareTo(CreatedAt.AddMonths(2)) <= 0;
            
        }

        public bool IsDeactive()
        {
            if (Status == StudentStatus.Deactive)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Rollnumber{RollNumber},Fullname{FullName},Email{Email},Birthday{Birthday},Phone{Phone},Status{Status},Datetime{CreatedAt}";
        }

    }
}