using System;
using System.Collections.Generic;

namespace LearningArrays
{
    class Program
    {
        public static int[] MyPropertyArray { get; set; } = new int[6];


        static void Main(string[] args)
        {
            //Working with Linked List Stacks
            LinkListQueue<int> myListQueue = new LinkListQueue<int>();
            LinkListStack<int> mylinklist = new LinkListStack<int>();

            CircularBuffer<string> myBuffer = new CircularBuffer<string>(3);

            Console.WriteLine("Below is my linked list: ");
            mylinklist.Push(1);
            mylinklist.Push(2);
            mylinklist.Push(3);
            mylinklist.Push(4);
            mylinklist.Pop();
       
            mylinklist.Peek();

            //Working with Linked List Queues
            Console.WriteLine("Below is my Queue:");
            myListQueue.Enqueue(1);
            myListQueue.Enqueue(2);
            myListQueue.Enqueue(3);
            myListQueue.Enqueue(4);

            myListQueue.Dequeue();
            myListQueue.Dequeue();

            //Working with single Dimension Arrays
            var sizeOfArray = Program.MyPropertyArray.Length;
            Program.MyPropertyArray[0] = 32;
            Program.MyPropertyArray[1] = 32;
            Program.MyPropertyArray[2] = 32;
            Program.MyPropertyArray[3] = 32;
            Program.MyPropertyArray[4] = 32; 
            Program.MyPropertyArray[5] = 32;

            var getTheLength = Program.MyPropertyArray.GetLength(0);

            Console.WriteLine($"The length of my array property is:  {sizeOfArray}");
            Console.WriteLine($"The length of my array property is: {getTheLength}");

            Console.WriteLine($"The Circluar Buffer");
            myBuffer.Push("First go");
            myBuffer.Push("Second go");
            myBuffer.Push("Third go");
            myBuffer.Push("Fourth go");


            foreach (var item in myBuffer.DisplayBuffer())
            {
                Console.WriteLine(item);
            } 

            foreach (var number in GetSingleDigitNumbers())
            {
                Console.WriteLine(number);
            }

            foreach (var number in GenerateWithoutYield())
            {
                Console.WriteLine(number);
            }

            foreach (var number in GenerateWithYield())
            {
                Console.WriteLine(number);
            }
        }

        private static IEnumerable<int> GenerateWithoutYield()
        {
            var i = 0;
            var list = new List<int>();
            while (i < 5)
                list.Add(++i);
            return list;
        }

        private static IEnumerable<int> GenerateWithYield()
        {
            var i = 0;
            var list = new List<int>();
            while (i < 5)
                yield return ++i;
        }

        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }


    }

    //Stack and Queue 
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        //Constructor to create a new node.Next is by default initialized as null
        public Node(T data)
        {
            this.data = data;
            next = null;
        }

    }
  
}
