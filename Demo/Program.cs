using System;
using Demo.Models;

namespace Demo
{
    public enum StudentStatus
    {
        Active = 1,
        Deactive = 0,
        Deleted = -1
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
                CreateAt = DateTime.Now,
                Status = StudentStatus.Active
            };
            //Console.WriteLine(st.ToString());
            Console.WriteLine((int)st.Status);
        }
    }
}