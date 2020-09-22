using System;

namespace LearningGenericDelegates
{
    class Program
    {
        public delegate double AddNumber1Delegate(int no1, float no2, double no3);
        public delegate void AddNumber2Delegate(int no1, float no2, double no3);
        public delegate bool CheckLengthDelegate(string name);

        static void Main(string[] args)
        {
            AddNumber1Delegate del1 = new AddNumber1Delegate(AddNumber1);
            double Result = del1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);

            AddNumber2Delegate del2 = new AddNumber2Delegate(AddNumber2);
            del2.Invoke(50, 255.45f, 123.456);

            CheckLengthDelegate del3 = new CheckLengthDelegate(CheckLength);
            bool Status = del3.Invoke("Pranaya");
            Console.WriteLine(Status);

            Console.WriteLine("Using the Generic Delegates");

            Func<int, float, double, double> gDel1 = new Func<int, float, double, double>(AddNumber1);
            double FuncResult = gDel1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(FuncResult);

            Action<int, float, double> gDel2 = new Action<int, float, double>(AddNumber2);
            gDel2.Invoke(50, 255.45f, 123.456);

            Predicate<string> gDel3 = new Predicate<string>(CheckLength);
            bool StatusUpdate = gDel3.Invoke("Pranya");
            Console.WriteLine(StatusUpdate);

        }

        public static double AddNumber1(int no1, float no2, double no3) 
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3) 
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name) 
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
