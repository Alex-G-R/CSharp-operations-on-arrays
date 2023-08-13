using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_Ww
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[5, 5];
            Random r = new Random();

            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    // fill up the array tab with:
                    // Random numbers betwen 1 and 9
                    tab[i, j] = r.Next(1, 10);
                }
            }

            // print the array tab to the console
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0;j  < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            // calculate the diagonals
            int mainDiagonal = 0;
            int antiDiagonal = 0;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                mainDiagonal += tab[i, i];
                antiDiagonal += tab[i, tab.GetLength(0) - i - 1];
            }
            Console.WriteLine("Sum of main diagonal: " + mainDiagonal);
            Console.WriteLine("Sum of anti diagonal: " + antiDiagonal);

            Console.ReadKey();
        }
    }
}
