using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestSha1()
        {
            byte[] message = new byte[] { 0, 1, 2 };

            byte[] result = CoreSample.Program.Sha1(message);

            CollectionAssert.AreEqual(
                result,
                new byte[] {
                    0x0c, 0x7a, 0x62, 0x3f, 0xd2, 0xbb, 0xc0, 0x5b,
                    0x06, 0x42, 0x3b, 0xe3, 0x59, 0xe4, 0x02, 0x1d,
                    0x36, 0xe7, 0x21, 0xad
                }
            );
        }
    }
}
