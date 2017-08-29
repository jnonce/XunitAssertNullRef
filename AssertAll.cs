using System;
using Xunit;
using Xunit.Sdk;

namespace XunitAssertNullRef
{
    public class AssertAll
    {
        [Fact]
        public void WillNeverProduceResult()
        {
            object[] collection = new object[]
            {
                new object(),
                null
            };

            Assert.All(collection, Assert.NotNull);
        }

        [Fact]
        public void ThrownExceptionProducesNullRef()
        {
            AllException exception = Assert.Throws<AllException>(() => WillNeverProduceResult());

            Assert.Throws<NullReferenceException>(() => exception.Message);
        }
    }
}
