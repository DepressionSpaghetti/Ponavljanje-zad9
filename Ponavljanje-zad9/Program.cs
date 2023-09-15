using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 15, 26, 17, 194, 14, 70 };

            Array.Sort(arr);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
