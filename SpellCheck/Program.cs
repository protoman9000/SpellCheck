using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                string insert = Console.ReadLine();
                words[x] = insert;
                x++;
            }

            using (StreamReader r = File.OpenText(@"C:\Users\Aziz\Downloads\Dict.txt"))
            {

            }
        }
    }
}
