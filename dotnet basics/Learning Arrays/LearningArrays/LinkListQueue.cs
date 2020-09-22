using System;


namespace LearningArrays
{
    internal class LinkListQueue<T>
    {
        Node<T> front;
        Node<T> rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        internal void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }

            Console.WriteLine("{0} inserted into the Queue", value);
        }
        internal void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is Empty");
                return;
            }

            //Store previous front and move front one node ahead
            Node<T> temp = this.front;
            this.front = this.front.next;

            //if front becomes Null, then change rear alsao NULL
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
    }
}
