using System;
using System.Collections.Generic;
using Demo.Models;

namespace Demo
{
    public enum StudentStatus
    {
        Active = 1,
        Deactive = 0,
    }
    internal class Program
    {
        public static void Main(string[] args)
        { 
            var st = new Student
            {
                RollNumber = "H1",
                FullName = "Phan Hieu",
                Birthday = DateTime.Parse("2002-03-13"),
                Email = "hieu@gmail.com",
                Phone = "0987654231",
                CreatedAt = DateTime.Parse("2020-10-01"),
                Status = StudentStatus.Active
            };
            if (st.IsNewStudent())
            {
                Console.WriteLine("Hoc sinh moi");
            }
            else
            {
                Console.WriteLine("Hoc sinh cu");
            }
            
            Console.WriteLine(st.IsDeactive());
            //Console.WriteLine(st.IsNewStudent());
            
            //Console.WriteLine(st.ToString());
            //Console.WriteLine((int)st.Status);
            
            var listStudent = new List<Student>();
            var studentController = new StudentController();
            listStudent.Add(studentController.CreateStudent());
        }
    }
}