using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point):this()
        {

            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine("Melumatlari zehmet olmasa yoxlayin");
            Console.WriteLine($"Id{Id}, FullName{Fullname}, Point{Point}");
        }
        static Student()
        {
            _id = 0;
        }
        private Student()
        {
            Id = ++_id;

        }
    }
}





    

