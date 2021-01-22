using Xunit;
using XUnitPracticeDemo.Test;

namespace XUnitPracticeDemo.Test
{
    [CollectionDefinition("Long Time Task Collection")]
    public class LongTimeTaskCollection : ICollectionFixture<LongTimeTaskFixture>
    {
       
    }
}
