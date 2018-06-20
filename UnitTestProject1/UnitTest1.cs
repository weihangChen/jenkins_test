using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tmp = new ClassLibrary1.Class1();
            tmp.Fire();
            Assert.IsTrue(1 == 1);
        }
    }
}
