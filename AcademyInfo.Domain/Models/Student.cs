﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyInfo.Domain.Models
{
    public class Student
    {
        private int _id;
        public int Id 
        {
            get {  return _id; }
            
        }
        public string FullName { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point)
        {
            FullName = fullname;
            Point = point;
            _id++;
        }

    }
}