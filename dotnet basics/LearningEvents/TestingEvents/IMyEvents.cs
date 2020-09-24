using System;
using System.Collections.Generic;
using System.Text;

namespace LearningEvents.TestingEvents
{
    public delegate void TestFloatEventDelegate(float f);
    public delegate void TestIntEventDelegate(int i);
    public delegate void TestDoubleEventDelegate(double d);
    public delegate void TestDateEventDelegate(DateTime dt);
    public delegate void TestStringEventDelegate(string s);

    interface IMyEvents
    {
        public event TestFloatEventDelegate OnFloatEvent;
        public event TestIntEventDelegate OnIntEvent;
        public event TestStringEventDelegate OnStringEvent;
    }
}
