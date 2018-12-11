using System;
using System.Security.Cryptography;

namespace CoreSample
{
    public class Program
    {
        public static byte[] Md5(byte[] message)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(message);
            }
        }

        public static byte[] Sha1(byte[] message)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(message);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Md5");
            byte[] message = new byte[] { 0, 1, 2 };
            byte[] hash = Md5(message);
            Console.WriteLine("  Message: " + string.Join(",", message));
            Console.WriteLine("  Hash: " + string.Join(",", hash));

            Console.WriteLine("Sha1");
            message = new byte[] { 0, 1, 2 };
            hash = Sha1(message);
            Console.WriteLine("  Message: " + string.Join(",", message));
            Console.WriteLine("  Hash: " + string.Join(",", hash));
        }
    }
}
