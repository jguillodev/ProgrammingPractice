using System;
using System.Collections.Generic;
using System.Text;

namespace LearningEvents.TestingEvents
{
    public class Subscriber
    {

        public Subscriber(Publisher publisher)
        {
            
            publisher.OnFloatEvent += Publisher_OnFloatEvent;
            publisher.OnIntEvent += Publisher_OnIntEvent;
            publisher.OnStringEvent += Publisher_OnStringEvent;

        }

        private void Publisher_OnStringEvent(string s)
        {
            Console.WriteLine("This is a string event: " + s);
        }

        private void Publisher_OnIntEvent(int i)
        {
            Console.WriteLine("This is a int event: " + i);
        }

        private void Publisher_OnFloatEvent(float f)
        {
            Console.WriteLine("This is a float event: " + f);
        }
    }
}
