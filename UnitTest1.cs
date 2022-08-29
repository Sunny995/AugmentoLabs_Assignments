using System;
using Xunit;

namespace ExtensionTests
{
    public class UnitTest1
    {
        [Fact]
        public void ToCurrency_Returns_DollarAppendedForOnlyNumbers()
        {
            string s = "322";
            var result = Extension.Extension.ToCurrency(s);
            Assert.Equal("$322", result);
        }

        [Fact]
        public void ToCurrency_Throws_ExceptionIfNonnumeric()
        {
            Assert.Throws<Exception>(() => Extension.Extension.ToCurrency("Hello"));
        }
    }
}
