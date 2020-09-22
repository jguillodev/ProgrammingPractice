using System;
using System.Collections.Generic;
using System.Text;

namespace LearningArrays
{
    public class CircularBuffer<T>
    {
        public T[] Buffer
        {
            get;
            set;
        }
        public int NewestValue { get; set; } = 0;
        
   


        public CircularBuffer(int size) 
        {
            if (size > 0)
            {
                this.Buffer = new T[size];
            }
            else
            {
                Console.WriteLine("Buffer size must be greater than 0!");
            }
        }
          

 

        public void Push(T item) 
        {
           
            for (int i = 0; i < Buffer.Length; i++)
            {
                if (Buffer[i] == null) 
                {
                    Buffer[i] = item;
                    NewestValue = i;
                    Console.WriteLine($"New value added: {Buffer[i]} ");
                    return;
                }                    
            }

            if (NewestValue == Buffer.Length - 1)
            {
                Buffer[0] = item;
                NewestValue = 0;
                return;
            }
            else
            {
                Buffer[NewestValue + 1] = item;
                NewestValue++;
            }
        }

        public IEnumerable<T> DisplayBuffer() 
        {
            for (int i = 0; i < Buffer.Length; i++)
            {
                if (Buffer[i] != null)
                {
                    yield return Buffer[i];
                }
                else
                    yield break;
            }
        }
    }
}
