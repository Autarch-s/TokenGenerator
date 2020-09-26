using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generator
{
    class Gen
    {


        public static string _charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        static void Main(string[] args)
        {
            while (true)
            {   
                //for (; ; )
                //{

                //
                string Token = "NzE4" + RandomString(20) + ".Xv" + RandomString(4) + "." + RandomString(27);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Token);
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine(" - Generated");
                Thread.Sleep(1);
                //Console.ReadLine(); // remove this line if you wanna loop infinitely!
                }
            //}
        }

        internal static char RandomChar(System.Random rand)
        {
            return _charset[rand.Next(_charset.Length)];
        }
        internal static string RandomString(int length = 16)
        {
            var result = string.Empty;
            var rand = new System.Random(DateTime.Now.Millisecond);

            for (var i = 0; i < length; i++)
            {
                result += RandomChar(rand);
            }

            return result;
        }
    }
}
