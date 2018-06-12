using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20___Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            int firstEl = a[0];
            int lastEl = a[a.Length - 1];

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {firstEl}");
            Console.WriteLine($"Last Element: {lastEl}");
        }
    }
}
