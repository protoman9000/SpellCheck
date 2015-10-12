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
                Console.WriteLine("Enter word number " + x + ":");
                string insert = Console.ReadLine();
                words[x - 1] = insert;
                x++;
            }

            //the plan is to check the words, character by character until we get a mismatch
            foreach (string word2 in words)
            {
                string line;
                string tmp2;
                int set = 0;
                int v = 1;
                using (StreamReader r = File.OpenText(@"C:\Users\Aziz\Downloads\Dict.txt"))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        int k = line.Length;
                        int x = k;
                        while (set <= word2.Length)
                        {
                            if (word2.Substring(0, v) == line.Substring(0, (k - (x - 1))))
                            {
                                try
                                {

                                }
                                catch(ArgumentOutOfRangeException e)
                                {
                                    continue;
                                }
                                set++;
                                v++;
                                x--;
                            }
                            else
                            {
                                continue;
                            }                                          
                        }
                    }
                        StringBuilder sb = new StringBuilder();
                        sb.Append(word2);
                        sb.Insert(set, ">");
                        tmp2 = word2;
                        tmp2 = sb.ToString();                                                                       
                    }                   
                }
            }
        }
    }
