using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16___Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
                throw;
            }
        }
    }
}
