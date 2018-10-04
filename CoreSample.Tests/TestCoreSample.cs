using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CoreSample.Tests
{
    [TestClass]
    public class TestCoreSample
    {
        [TestMethod]
        public void TestMd5()
        {
            byte[] message = new byte[] { 0, 1, 2 };

            byte[] result = CoreSample.Program.Md5(message);

            CollectionAssert.AreEqual(
                result,
                new byte[] {
                    185, 95, 103, 246, 30, 187, 3, 97,
                    150, 34, 215, 152, 244, 95, 194, 211
                }
            );
        }
    }
}
