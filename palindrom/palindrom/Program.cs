

using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string pal =Console.ReadLine();
            char[] chars = pal.ToCharArray();
             
             
            for (int i = chars.Length; i>=0; i--)
            {
                Console.WriteLine();
            }
        }
        
    }
}
