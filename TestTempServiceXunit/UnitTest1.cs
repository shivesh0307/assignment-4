using System;
using TempService;
using Xunit;

namespace TestTempServiceXunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var temp = new Temp();
           
            var t1 = temp.CTF(0);
            var t2 = temp.CTF(11);
            var t3 = temp.CTF(-11);
            Assert.Equal(t1, 32.0);
            Assert.Equal(51.8, t2,2);
            Assert.Equal(12.2,t3,2);
        }
    }
}
