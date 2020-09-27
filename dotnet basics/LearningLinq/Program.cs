using System;
using System.Linq;

namespace LearningLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bil","Steve","James","Mohan" };

            var myLinqQuery = from name in names where name.Contains('a') select name;

            foreach (var name in myLinqQuery) 
            {
                Console.Write($"{name},  ");
            }

            Student[] studentArray = 
                {
                    new Student() { StudentID = 1, StudentName ="John", Age = 18 },
                
                };
                
        }
    }

    internal class Student 
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
