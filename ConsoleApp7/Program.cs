using ConsoleApp7.Models;
using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Heci", "Feyzullayev", 15, 75);
            Student s2 = new Student("Dadas", "Dadasov", 20, 63);
            Student s3 = new Student("Fazil", "Heybullayev", 45, 79);
            Student s4 = new Student("Nicat", "Qarayev", 25, 29);

            
            s1.ShowInfo();
            Console.WriteLine("================");
            s2.ShowInfo();
            Console.WriteLine("================");
            s3.ShowInfo();
            Console.WriteLine("================");
            s4.ShowInfo();
            Console.WriteLine("================");



            Group g1 = new Group();
            #region
            g1.AddStudent(s1);
            g1.AddStudent(s2);
            g1.AddStudent(s3);
            g1.AddStudent(s4);
            #endregion


            #region Sort 
            Console.WriteLine("------Sort olunmus------");
            foreach (var item in g1.Sort())
            {
                item.ShowInfo();
                Console.WriteLine("================");
            }
            #endregion

            

           
        }
    }
}
