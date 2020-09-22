using System;
using System.Collections;

namespace LearningArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("some string");
            


            //Boxing
            int i = 123;
            object o = i;

            //Unboxing
            i = (int)o;
            String s = (String)list[0];

           
            Console.WriteLine(s);
        }
    }
}
