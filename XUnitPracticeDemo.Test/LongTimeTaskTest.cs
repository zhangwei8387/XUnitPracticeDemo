using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitPracticeDemo.Test
{
    [Collection("Long Time Task Collection")]
    public class LongTimeTaskTest  // :IClassFixture<LongTimeTaskFixture>
    {
        private readonly LongTimeTask task;
        private readonly LongTimeTaskFixture fixture;

        public LongTimeTaskTest(LongTimeTaskFixture fixture)
        {
           
            this.fixture = fixture;
            task = fixture.Task;
        }

        [Fact]
        public void TestMethod1()
        {

        }
        [Fact]
        public void TestMethod2()
        {

        }


        [Fact]
        public void TestMethod3()
        {

        }

        [Fact]
        public void TestMethod4()
        {

        }
    }
   
}

