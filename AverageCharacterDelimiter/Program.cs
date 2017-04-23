using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"F:\input.txt"));
#endif

            int sum = 0, index = 0;
            string[] array = Console.ReadLine().Split().ToArray();

            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sum += item[i];
                    index++;
                }
            }

            Console.WriteLine(String.Join($"{((char)(sum / index)).ToString().ToUpper()}", array));
        }
    }
}
