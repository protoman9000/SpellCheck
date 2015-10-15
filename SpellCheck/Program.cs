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
            int x = 1;

            //Entering in the words we want to check.
            foreach (string word in words)
            {               
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
                int num = 0;
                int set = 0;
                int set2 = 0;
                int v = 1;
                int check = 0;
                using (StreamReader r = File.OpenText(@"C:\Users\Aziz\Downloads\Dict.txt"))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        int k = line.Length;
                        int l = k;
                        num = 0;
                        set = 0;
                        set2 = 0;
                        v = 1;
                        
                        //If the first letter of both words do not match, it will skip. 
                        if (word2.Substring(0, 1) != line.Substring(0, 1) || word2.Length != line.Length)
                        {
                            continue;
                        }
                        
                        while (num < line.Length)
                        {
                            if (word2.Substring(0, v) == line.Substring(0, (k - (l - 1))))
                            {
                                num++;
                                set++;
                                v++;
                                l--;
                            }
                            else
                            {
                                if (check > set)
                                {
                                    num++;
                                }
                                else
                                {
                                    set2 = set;
                                    check = set2;
                                    num++;
                                }
                                continue;
                            }                                          
                        }
                    }
                        StringBuilder sb = new StringBuilder();
                        sb.Append(word2);
                        sb.Insert(check + 1, "<");
                        tmp2 = word2;
                        tmp2 = sb.ToString();
                        Console.WriteLine(tmp2);
                        Console.ReadKey();                               
                    }                   
                }
            }
        }
    }
