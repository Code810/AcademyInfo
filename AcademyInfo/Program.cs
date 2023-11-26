
using AcademyInfo.Domain.Models;

Student student1 = new("Nadir Shirinbayli",55);
student1.StudentInfo();
Student student2 = new("Eli Eliyev", 44);
student2.StudentInfo();
Student student3 = new("Memmed Memmedli", 66);
student3.StudentInfo();
Student student4 = new("Memmed Memmedli", 66);
Student student5 = new("Memmed Memmedli", 77);
Student student6 = new("Memmed Memmedli", 88);


Group group1 = new("PB518",5);

group1.AddStudenArr(student1);
group1.AddStudenArr(student2);
group1.AddStudenArr(student3);
group1.AddStudenArr(student4);
group1.AddStudenArr(student5);
group1.AddStudenArr(student6);

group1.GetStudent(5).StudentInfo();

