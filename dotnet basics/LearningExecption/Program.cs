using System;

namespace LearningExecption
{
    class PersonException : Exception
    {
        public PersonException(String name) 
        {
            Name = name;
        }

        public String Name { get; set; }
    }
    class Person 
    {
        private String name;

        public String Name 
        {
            get { return name; }
            set 
            {
                try 
                {
                    if (value == null)
                        throw new NullReferenceException("name must have a value");

                    name = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("name can not be null");
                    throw;
                }
             
            }
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {

           
            //Console.WriteLine("connected to database");
            //try
            //{
            //    throw new Exception("error while accesing database resource");
            //}
            //catch
            //{
            //    Console.WriteLine("exception caught");
            //}
            //finally 
            //{
            //    Console.WriteLine("disconnecting database");
            //}
            //try
            //{
            //    var person = new Person();
            //    person.Name = null;

            //}
            //catch (DivideByZeroException ex) 
            //{
            //    Console.WriteLine(ex);
            //}
            //catch (NullReferenceException ex) 
            //{
            //    Console.WriteLine(ex);
            //}
        }
    }
}
