using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Models
{
    internal class Student
    {
        private static int _id = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nPoint:{Point}");
        }
        public  Student(string name, string surname, int age, int point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
            Age = age;

           

        }
        public static bool operator >(Student name1, Student name2)
        {
            return name1.Point > name2.Point;
        }
        public static bool operator <(Student name1, Student name2)
        {
            return name1.Point < name2.Point;
        }


    }
}
