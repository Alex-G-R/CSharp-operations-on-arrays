using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = {9, 7, 8, 2, 1, 5, 3, 6, 4};



            Console.Write("Before Bubble sort: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine();


            // Sort the numbers
            int temp;

            // Loop through 1 less than the length of array bc we comparing it to the number after the current number
            // So we don't need to go to the last position in the array
            for (int i = 0; i < array.Length - 1; i++)
            {
                // i is the current position we solve for
                // add i to not go to the last element as that element have already been moved
                for(int j = 0; j < array.Length - ( 1 + i); j++)
                {
                    // first to last [j] and [j + 1] for example [2] and [3]
                    if (array[j] > array[j + 1])
                    {
                        // If current is greater that the next one swap it forward - move to the right
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }


            Console.Write("After Bubble sort: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
