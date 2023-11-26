using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyInfo.Domain.Models
{
    public class Student
    {
        private static int _id;
        public int Id;
        public string FullName { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point)
        {
            FullName = fullname;
            Point = point;
           
            _id++;
            Id = _id;
        }

        public void StudentInfo()

        {
            Console.WriteLine($"Id: {Id} Fullname: {FullName} Point:{Point} ");
        }
    }
}
