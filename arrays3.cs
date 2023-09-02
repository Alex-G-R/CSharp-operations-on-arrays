using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] tab = new int[5, 5];
            Random r = new Random();

            int main = 0;
            int anti = 0;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = r.Next(1, 10);
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for(int i = 0; i < tab.GetLength(0); i++)
            {
                main += tab[i, i];
                anti += tab[i, tab.GetLength(0) - i - 1];
            }
            Console.WriteLine($"Main diagonal: {main}, Anti diagonal: {anti}");



            Console.ReadKey();
        }
    }
}
