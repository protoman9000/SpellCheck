using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many words?");
            string entry = Console.ReadLine();
            int number = Convert.ToInt16(entry);
            string[] words = new string[number];

            foreach (string word in words)
            {
                int x = 1;
                Console.WriteLine("Enter word number" + x + ":");
                x++;
            }
        }
    }
}
