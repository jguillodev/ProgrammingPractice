using System;
using System.Collections.Generic;
using System.Text;

namespace LearningArrays
{
    public class LinkListStack<T>
    {
        Node<T> topNode;

        public LinkListStack()
        {
            this.topNode = null;
        }

        public Node<T> Push(T value)
        {
            
            Node<T> newNode = new Node<T>(value);
            if (topNode == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = topNode;
            }
            topNode = newNode;
            Console.WriteLine("{0} pushed to stack", value);
            return newNode;
        }
        public bool Pop()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return false;
            }

            Console.WriteLine("Item popped is {0}", topNode.data);
            topNode = topNode.next;
            return true;
        }
        public T Peek()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack Underflow.");
                return default(T);
            }

            Console.WriteLine("{0} is on the top of Stack", this.topNode.data);
            return this.topNode.data;
        }

    }
}
