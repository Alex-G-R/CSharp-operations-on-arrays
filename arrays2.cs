using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                    tab[i, j] = r.Next(1, 10);
                }
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int anti = 0;
            int main = 0;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                main += tab[i, i];
                anti += tab[i, tab.GetLength(0) - i - 1];
            }
            Console.WriteLine($"Main diagonal sum: {main}");
            Console.WriteLine($"Anti diagonal sum: {anti}");

            Console.ReadKey();
        }
    }
}
