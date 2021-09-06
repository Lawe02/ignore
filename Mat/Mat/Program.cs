using System;

namespace Mat
{
    class Program
    {
        static void Main(string[] args)
        {



            int antalFrågor = 3;
            string[] food = new string[antalFrågor];

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("Ange en maträtt");
                food[i] = Console.ReadLine();
            }
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i] + " ");
            }
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i] + "(" + food[i].Length + ")");
            }

            string längstMat = food[0];
            if (food[0].Length < food[1].Length )
            {
                längstMat = food[1];
            }
            if (food[1].Length < food[2].Length )
            {
                längstMat = food[2];
            }

            Console.WriteLine("Längsta maträtten är " + längstMat);

            Console.ReadLine();

        }
    }
}
