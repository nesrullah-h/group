using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Models
{
    internal class Group
    {
        private static int _no = 100;
        public string No { get; }

        private Student[] students;
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student[] GetAllStudents()
        {
            return students;
        }

        public Student [] Sort()
        {
            Student[] newstudent = new Student[students.Length];
            Array.Copy(students, newstudent , students.Length);
            for(int i = 0; i < newstudent.Length - 1; i++)
            {
                for(int j = 0; j < newstudent.Length - i - 1; j++)
                {
                    if (newstudent[j] > newstudent[j + 1])
                    {
                        Student sort =newstudent[j];
                        newstudent[j]=newstudent[j + 1];
                        newstudent[j+1]=sort;
                    }
                }
            }
            return newstudent;
        }
        
        public Group()
        {
            _no++;
            No = "AP" + _no;
            students = new Student[0];
        }
            
    }
}
