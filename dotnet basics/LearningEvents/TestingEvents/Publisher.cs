using System;
using System.Collections.Generic;
using System.Text;

namespace LearningEvents.TestingEvents
{
    //public delegate void TestFloatEventDelegate(float f);
    //public delegate void TestIntEventDelegate(int i);
    //public delegate void TestDoubleEventDelegate(double d);
    //public delegate void TestDateEventDelegate(DateTime dt);
    //public delegate void TestStringEventDelegate(string s);
 

    public class Publisher: IMyEvents
    {
        public event TestFloatEventDelegate OnFloatEvent;
        public event TestIntEventDelegate OnIntEvent;
        public event TestStringEventDelegate OnStringEvent;

        public void PublishEvents() 
        {
            
            OnFloatEvent?.Invoke(4.5f);
            OnIntEvent?.Invoke(4);
            OnStringEvent?.Invoke("Go GO PowerRangers");
        }

    }
}
