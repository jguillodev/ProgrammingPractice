using System;
using System.Collections.Generic;
using System.Text;

namespace LearningInterfaces.InterfaceDemo
{
    interface A
    {
        void method1();
        void method2();
    }
    interface B : A 
    {
        void method3();
    }
    interface C 
    {
        string method1();
    }
    class MyClass : B, C
    {
        public void method1()
        {
            throw new NotImplementedException();
        }

        public void method2()
        {
            throw new NotImplementedException();
        }

        public void method3()
        {
            throw new NotImplementedException();
        }
    }
}
