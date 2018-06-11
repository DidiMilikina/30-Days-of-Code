using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8___Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');
                phoneBook.Add(s[0], s[1]);
            }

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (phoneBook.ContainsKey(s))
                {
                    Console.WriteLine(s + "=" + phoneBook[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
