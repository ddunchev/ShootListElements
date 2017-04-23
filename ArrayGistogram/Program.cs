using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"E:\input.txt"));
#endif

            string[] array = Console.ReadLine().Split().ToArray();
            int length = array.Length;
            int count = 0;

            var myList = GetUniqueValues(array);
            var frequent = new List<int>();

            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (string.Compare(array[j], myList[i]) == 0)
                    {
                        count++;
                    }
                }
                frequent.Add(count);
                count = 0;
            }


            bool swapped;
            do
            {
                swapped = false;

                for (int i = 0; i < frequent.Count - 1; i++)
                {
                    if (frequent[i] < frequent[i + 1])
                    {
                        Swap(myList, i, i + 1);
                        Swap2(frequent, i, i + 1);

                        swapped = true;
                    }
                }
            } while (swapped);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{myList[i]} -> {frequent[i]} times ({(float)frequent[i] / length * 100:.00}%)");
            }
        }

        private static List<string> GetUniqueValues(string[] array)
        {
            var list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!list.Contains(array[i])) list.Add(array[i]);
            }
            return list;
        }

        private static void Swap(List<string> array, int i, int j)
        {
            string temp;
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

        private static void Swap2(List<int> array, int i, int j)
        {
            int temp;
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
