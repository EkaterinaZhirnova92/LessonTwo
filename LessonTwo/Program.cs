using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonTwo
{ 
    class Student
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Connor";
        public string Group { get; set; } = "WPU221";
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public void Print()
        {
            WriteLine($"Имя: {FirstName}\n Фамилия: {LastName}\n Дата рождения: {BirthDate}\n Группа: {Group}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                FirstName = "Sahra",
                LastName = "Connor",
                BirthDate = new DateTime(1966, 3, 8),
                Group = "T1000",
            };
            Student student2 = new Student
            {
                FirstName = "Arnold",
                LastName = "Schwarznegger",
                BirthDate = new DateTime(1946, 12, 23),
                Group = "T800",
            };
            Student student3 = new Student
            {
                FirstName = "Robert",
                LastName = "Patrik",
                BirthDate = new DateTime(1966, 7, 18),
                Group = "T1000",
            };
            Student student4 = new Student();
            student1.Print();
            student2.Print();
            student3.Print();
            student4.Print();
        }
    }
}
