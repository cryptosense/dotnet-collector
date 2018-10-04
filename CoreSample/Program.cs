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

        static void Main(string[] args)
        {
            Console.WriteLine("md5DirectArray");
            byte[] message = new byte[] { 0, 1, 2 };
            byte[] hash = Md5(message);
            Console.WriteLine("  Message: " + string.Join(",", message));
            Console.WriteLine("  Hash: " + string.Join(",", hash));
        }
    }
}
