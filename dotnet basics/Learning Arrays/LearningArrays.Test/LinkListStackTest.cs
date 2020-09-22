using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningArrays.Test
{
    public class LinkListStackTest
    {
        [Fact]
        public void IsPushStackTrue() 
        {
            var testStack = new LinkListStack<int>();

            var condition = testStack.Push(1);

            Assert.True(condition);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void IsPeekEqualToLastValuePush(int data)
        {
            var testStack = new LinkListStack<int>();

            testStack.Push(data);
            testStack.Push(data);
            testStack.Push(data);
            testStack.Push(data);


            Assert.Equal( data, testStack.Peek() );
        }

        
    }
}
