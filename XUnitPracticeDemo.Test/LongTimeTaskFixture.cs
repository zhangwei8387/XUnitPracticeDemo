using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitPracticeDemo.Test
{

    public class LongTimeTaskFixture : IDisposable
    {
        public LongTimeTask Task { get; }
        public LongTimeTaskFixture()
        {
            Task = new LongTimeTask();
        }
        public void Dispose()
        {

        }
    }
}
