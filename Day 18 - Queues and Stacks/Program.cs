using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_18___Queues_and_Stacks
{
    class Solution
    {
        public Stack<char> charS = new Stack<char>();
        public Queue<char> charQ = new Queue<char>();

        void pushCharacter(char c)
        {
            charS.Push(c);
        }

        char popCharacter()
        {
            return charS.Pop();
        }
        void enqueueCharacter(char c)
        {
            charQ.Enqueue(c);
        }

        char dequeueCharacter()
        {
            return charQ.Dequeue();
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Solution obj = new Solution();

            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
