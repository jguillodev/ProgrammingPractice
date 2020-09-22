using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace LearningConcurrentDictionary
{
    class Program
    {
        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(AddItem));
            Thread t2 = new Thread(new ThreadStart(AddItem));

            t1.Start();
            t2.Start();
        }

        static void AddItem() 
        {
            items.TryAdd(1, 2);
            Console.WriteLine(items.Count);
        }
    }
}
