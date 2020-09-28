using System;
using System.Collections;
using System.Linq;

namespace LearningLinq
{
    delegate bool FindStudent(Student std);


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
                    new Student() { StudentID = 2, StudentName ="Steve", Age = 21},
                    new Student() { StudentID = 3, StudentName ="Bill", Age = 25},
                    new Student() { StudentID = 4, StudentName ="Ram", Age = 20},
                    new Student() { StudentID = 5, StudentName ="Ron", Age = 31},
                    new Student() { StudentID = 6, StudentName ="Chris", Age = 17},
                    new Student() { StudentID = 7, StudentName ="Rob", Age = 19 },   
                };

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student(){ StudentID = 8, StudentName = "Joe", Age= 200 });


            Student[] students = new Student[10];

            Console.WriteLine("Orginal list of students in the array");
            foreach (Student std in studentArray)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("Printed from the foreach statment");
            int i = 0;
            foreach (Student std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20) 
                {
                    students[i] = std;
                    i++;
                }
            }

            Console.WriteLine("Printed from the delegate");

            
            Student[] students1 = StudentExtension.Where(studentArray, delegate (Student std) 
            {
                return std.Age > 12 && std.Age < 20; 
            });

            Student[] students2 = StudentExtension.Where(studentArray, delegate (Student std) 
            {
                return std.StudentName == "Bill";
            });

            Student[] students3 = StudentExtension.Where(studentArray, delegate (Student std)
            {
                return std.StudentID == 5;
            });

            Console.WriteLine("Printed using Linq");

            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();

            var stringResult = from s in mixedList.OfType<string>() select s;

            var intResult = mixedList.OfType<int>();

            //Writing Linq statements using the OrderBy and OrderByDescending
            Console.WriteLine("List of Students in the using Order By");
            var orderByResult = from s in studentArray
                                orderby s.StudentName
                                select s;

            var studentsInAscOrder = studentArray.OrderBy(s => s.StudentName);
            var studentsInDescOrder = studentArray.OrderByDescending(s => s.StudentName);

            Console.WriteLine("List of Students in the using Order By Ascending");
            foreach (Student std in studentsInAscOrder) 
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("List of Students in the using Order By Descending");
            foreach (Student std in studentsInDescOrder)
            {
                Console.WriteLine(std.StudentName);
            }
        }
    }

    internal class Student 
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    internal class StudentExtension 
    {
        public static Student[] Where(Student[] stdArray, FindStudent del) 
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student student in stdArray)
            {
                if (del(student)) 
                {
                    result[i] = student;
                    i++;
                }
            }

            return result;
        }
    }
}
