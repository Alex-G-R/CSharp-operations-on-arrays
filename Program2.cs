using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_work_work_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int [5, 5];

            Random r = new Random();

            // fill up the array with random numbers
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = r.Next(1,9);
                }
            }

            //print out the array
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


            // calculate the main diagonal
            int mainDiagonalSum = 0;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                mainDiagonalSum += tab[i, i];
            }
            Console.WriteLine($"Sum of main diagonal: {mainDiagonalSum}");


            // calculacte the anti diagonal
            int antiDiagonalSum = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                antiDiagonalSum += tab[i, tab.GetLength(0) - i - 1];
            }
            Console.WriteLine($"Sum of anti-diagonal: {antiDiagonalSum}");

            Console.ReadKey();
        }
    }
}
