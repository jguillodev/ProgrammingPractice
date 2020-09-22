using System;

namespace LearningNull
{
    class Person 
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Console.WriteLine(person?.Name ?? "not set");

            int? i = null;
            int i2 = i ?? 2;

            var s = "null";
            var s2 = s ?? "default";

            Console.WriteLine(i2);
            
        }
    }
}
