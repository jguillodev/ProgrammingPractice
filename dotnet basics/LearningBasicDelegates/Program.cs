using System;

namespace LearningBasicDelegates
{
    //declare the delegate
    public delegate string MyDelegate(int arg1, int arg2);
    class Program
    {
        //Insert Delegates
        static string func1(int a, int b) 
        {
            return (a + b).ToString();
        }
        static string func2(int a, int b) 
        {
            return (a * b).ToString();
        }
        static void Main(string[] args)
        {
            MyDelegate f = func1;
            Console.WriteLine("The number is: " + f(10,20));
            f = func2;
            Console.WriteLine("The number is: " + f(10, 20));

            MyClass mc = new MyClass();
            f = mc.instanceMethod1;
            Console.WriteLine("The number is: " + f(10,20));


        }
    }

    class MyClass 
    {
        public string instanceMethod1(int arg1, int arg2) 
        {
            return ((arg1 + arg2).ToString());
        }
    }
}
