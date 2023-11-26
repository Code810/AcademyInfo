// See https://aka.ms/new-console-template for more information
using AcademyInfo.Domain.Models;

Console.WriteLine("Hello, World!");
Student student1 = new("Nadir",14);
Student[] students = new Student[18];
students[5] = student1;
Console.WriteLine(students[5].Point); 