using System;
using System.Collections.Generic;

namespace Demo.Models
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            
        }

        public Student CreateStudent()
        {
            Console.WriteLine("nhap ma so sv: " );
            var rollNumber = Console.ReadLine();
            Console.WriteLine("Nhap ten: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: yyyy/mm/dd  ");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Nhap SDT : ");
            var phone = Console.ReadLine();
            Console.WriteLine("Nhap trang thai: ");
            var studentstatus =(StudentStatus)int.Parse(Console.ReadLine()) ;
            var student = new Student()
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Birthday = birthday,
                Email = email,
                Phone = phone,
                Status = studentstatus
            };
            Console.WriteLine(student);
            return null;
        }
    }
}