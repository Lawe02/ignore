using System;

namespace VadHeterDu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Vad är ditt efternamn?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hej " + name +" "+ lastname );
        }
    }
}
