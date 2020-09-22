using System;
using System.Collections;
using Xunit;

namespace LearningArrays.Test
{
    public class CircularBufferTest
    {
        [Fact]
        public void TestBufferContainObjectLastPushed()
        {
            //arrange
            var testBuffer = new CircularBuffer<string>(7);

            //act
            testBuffer.Push("Here you go");

            //assert
            //foreach (var item in testBuffer.DisplayBuffer())
            //{
            //    Assert.Equal("Here you go", item);
            //}
            Assert.Contains("Here you go",testBuffer.Buffer);  

        }

        [Fact]
        public void IsDisplayBufferNotNull()
        {
            //arrange
            var testBuffer = new CircularBuffer<string>(7);

            //act
            testBuffer.Push("First go");
            testBuffer.Push("Second go");
            testBuffer.Push("Third you go");


            //assert
            foreach (var item in testBuffer.DisplayBuffer())
            {
                Assert.NotNull(item);
            }     
        }

        [Fact]
        public void IsBufferFullTest()
        {
            //arrange
            var testBuffer = new CircularBuffer<string>(4);

            //act
            testBuffer.Push("First go");
            testBuffer.Push("Second go");
            testBuffer.Push("Third go");
            testBuffer.Push("Fourth go"); 

            //assert
            foreach (var item in testBuffer.Buffer)
            {
                Assert.NotNull(item);
            }
            
        }
    }
}
