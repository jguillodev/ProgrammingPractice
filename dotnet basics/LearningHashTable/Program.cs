using System;
using System.Collections;

namespace LearningHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("title","MyWebsite");

            var s = (String)table["title"];
            Console.WriteLine(s);
        }
    }
}
