using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(456, OOP_lab_1_9_1.Program.Reverse(new char[] { '6', '5', '4' }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(321, OOP_lab_1_9_1.Program.Reverse(new char[] { '1', '2', '3' }));
        }
    }
}
