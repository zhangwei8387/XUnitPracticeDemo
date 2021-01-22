using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XUnitPracticeDemo
{
   public class LongTimeTask
    {
        public LongTimeTask()
        {
            Thread.Sleep(2000);
        }
    }
}
