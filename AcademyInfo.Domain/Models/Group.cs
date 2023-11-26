using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyInfo.Domain.Models
{
    public class Group
    {
        private string _groupno;
        public string GroupNo 
        {
            get {  return _groupno; }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                    Console.WriteLine("SUCSES");
                }
                else
                {
                    Console.WriteLine("Qrup nomresi duzgun deyil");
                }
                
            }
        }
        private int _studentLimit;
        public int StudentLimit 
        {
            get {  return _studentLimit; }
            set
            {
                if (value>=5 && value<=18)
                {
                    _studentLimit = value;
                    Array.Resize(ref Students, _studentLimit);
                }
                else
                {
                    Console.WriteLine("limit 5 den kicik 18 den boyuk ola bilmez");
                }
            }
        }
        public Group(string groupno,int studentlimit)
        {
                GroupNo = groupno;
                StudentLimit = studentlimit;
        }
        private static Student[] Students = new Student[5];
       
        public void AddStudenArr(Student student)
        {
            
            if (student.Id<=_studentLimit) 
            {
                Students[student.Id-1]=student;
            }
            else
            {
                Console.WriteLine("Telebe limitini kecmisiniz");
            }
        }
        public bool CheckGroupNo(string groupno)
        {
            Regex regex = new Regex(@"[A-Z]{2}[0-9]{3}");
            return  regex.IsMatch(groupno);
        }
        public Student GetStudent(int num)
        {
            return Students[num-1];
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
