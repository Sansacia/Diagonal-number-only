using System;

namespace Zadacha19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] cube = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        cube[i, j] = rnd.Next(10, 99);
                        Console.Write($" {cube[i, j]} ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}