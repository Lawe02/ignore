using System;

namespace citat
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, count = 1;

            Console.WriteLine("Vilket är ditt favoritcitat på minst 4 or");
            string citat = Console.ReadLine();


            while (i <= citat.Length -1)
            {
                if(citat[i] == ' ' )
                {
                    count++;
                }
                i++;
            }
             
            Console.WriteLine("Citatet är " + count + " ord långt." + "\n");

            string[] ord = citat.Split(' ');

            foreach (var ordEN in ord)
            {
                System.Console.WriteLine($"{ordEN}");
            }









        }
    }
}
