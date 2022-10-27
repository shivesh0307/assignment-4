using NUnit.Framework;
using TempService;
namespace TestTempServiceNUnit
{
    public class TestTempService
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestforCTF()
        {
            [Arrange]
            var temp = new Temp();
            [Act]
            var t1 = temp.CTF(0);
            var t2= temp.CTF(11);
            var t3 = temp.CTF(-11);
            [Assert]
            Assert.AreEqual(t1, 32.0);
            Assert.That( 51.8, Is.EqualTo(t2)).Within(0.01);
            Assert.That( 12.2, Is.EqualTo(t3)).Within(0.01);
        }
    }
}