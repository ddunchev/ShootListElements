using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"F:\input.txt"));
#endif


            string[] myArray = Console.ReadLine().Split().ToArray();
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (String.Compare(myArray[i], myArray[i + 1]) > 0)
                    {
                        Swap(myArray, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(String.Join(" ", myArray));
        }

        private static void Swap(string[] array, int i, int j)
        {
            string temp;
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
