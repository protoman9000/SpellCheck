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

            //Entering in the words we want to check.
            foreach (string word in words)
            {
                int x = 1;
                Console.WriteLine("Enter word number" + x + ":");
                string insert = Console.ReadLine();
                words[x] = insert;
                x++;
            }
            
            //the plan is to check the words, character by character until we get a mismatch
            foreach (string word2 in words)
            {
                string line;
                StreamReader r = File.OpenText(@"C:\Users\Aziz\Downloads\Dict.txt");
                while ((line = r.ReadLine()) != null)
                {                   
                    for(int set = 0; set <= word2.Length; set++)
                    {
                        if (word2.Substring(set).Contains(line))
                        {
                            continue;
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append(word2);
                            sb.Insert(set, ">");
                            string tmp = word2;
                            tmp = sb.ToString();
                            Console.WriteLine(tmp);
                        }
                    }
                }
            }
           
            
            
        }
    }
}
