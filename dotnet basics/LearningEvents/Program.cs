using System;

namespace LearningEvents
{
    public delegate void MyDelegate(string input);

    //Step 1 Create delegate object 
    public delegate void MyHandler1(object sender, MyEventArgs e);
    public delegate void MyHandler2(object sender, MyEventArgs e);

    internal class A 
    {
        public const string m_id = "Class_A";

        public void OnHandler1(object sender, MyEventArgs e) 
        {
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);
        }
        public void OnHandler2(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);
        }
        public A(B b) 
        {
            MyHandler1 d1 = new MyHandler1(OnHandler1);
            MyHandler2 d2 = new MyHandler2(OnHandler2);
            b.Event1 += d1;
            b.Event2 += d2;
        }
    }
    internal class B 
    {
        public event MyHandler1 Event1;
        public event MyHandler2 Event2;

        public void FireEvent1(MyEventArgs e) 
        {
            if (Event1 != null) 
            {
                Event1(this, e);
            }
        }
        public void FireEvent2(MyEventArgs e)
        {
            if (Event1 != null)
            {
                Event2(this, e);
            }
        }
    }
    public class MyEventArgs : EventArgs 
    {
        public string m_id;
    }

    internal class MyClass1
    {
        public void DelegateMethod1(string input)
        {
            Console.WriteLine("This is delegateMethod1 and the input to the method is {0}", input);
        }
        public void DelegateMethod2(string input)
        {
            Console.WriteLine("This is delegateMethod2 and the input to the method is {0}", input);
        }
    }

    internal class MyClass2
    {
        public MyDelegate createDelegate() 
        {
            MyClass1 c1 = new MyClass1();
            MyDelegate d1 = new MyDelegate(c1.DelegateMethod1);
            MyDelegate d2 = new MyDelegate(c1.DelegateMethod2);
            MyDelegate d3 = d1 + d2;
            return d3;
        }
    }
    internal class MyClass3
    {
        public void callDelegate(MyDelegate d, string input) 
        {
            d(input);
        }  
    }


    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            MyEventArgs e1 = new MyEventArgs();
            MyEventArgs e2 = new MyEventArgs();
            e1.m_id = "Now Tune into DJ TrashCrash";
            e2.m_id = "Now Tune into DJ OnYourLeft";
            b.FireEvent1(e1);
            b.FireEvent2(e2);


            //MyClass2 c2 = new MyClass2();
            //MyDelegate d = c2.createDelegate();
            //MyClass3 c3 = new MyClass3();
            //c3.callDelegate(d, "Calling the delegate");
        }
    }
}
