using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numbers = new int [5, 5];


            Random r = new Random();


            // fill up the numbers with random numbers
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    int rInt = r.Next(1,10);
                    numbers[i, j] = rInt;
                }
            }

            // Print the numbers
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("  ");
            }
            Console.WriteLine();


            // Sum up every number in the array
            int everyNumber = 0;
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    everyNumber += numbers[i, j];
                }
            }
            Console.WriteLine($"Sum of every number in the array: {everyNumber}");


            // Sum up first column
            int sumFirstColumn = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sumFirstColumn += numbers[i, 0];
            }
            Console.WriteLine($"Sum of every number in the first column: {sumFirstColumn}");


            // Sum up second row
            int sumSecondRow = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sumSecondRow += numbers[1, i];
            }
            Console.WriteLine($"Sum of every number in the second row: {sumSecondRow}");


            //Calculate diagonals
            int diagonalSum = 0;
            int antiDiagonalSum = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                diagonalSum += numbers[i, i];
                antiDiagonalSum += numbers[i, numbers.GetLength(0) - i - 1];
            }
            Console.WriteLine($"Sum of main diagonal: {diagonalSum}");
            Console.WriteLine($"Sum of anti-diagonal: {antiDiagonalSum}");


            Console.ReadKey();
        }
    }
}
