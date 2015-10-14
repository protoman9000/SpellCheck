﻿using System;
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
                int set2 = 0;
                int v = 1;
                int check = 0;
                using (StreamReader r = File.OpenText(@"C:\Users\Aziz\Downloads\Dict.txt"))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        int k = line.Length;
                        int x = k;
                        set = 0;
                        set2 = 0;
                        v = 1;
                        
                        //If the first letter of both words do not match, it will skip. 
                        if (word2.Substring(0, 1) != line.Substring(0, 1))
                        {
                            continue;
                        }
                        
                        while (set < line.Length)
                        {
                            if (word2.Substring(0, v) == line.Substring(0, (k - (x - 1))))
                            {
                                set++;
                                v++;
                                x--;
                                set2 = set;
                            }
                            else
                            {
                                check = set;
                                if (check <= set)
                                {
                                    set2 = set;
                                    set++;
                                    continue;
                                }
                                else
                                {
                                    set2 = check;
                                    set++;
                                    continue;
                                }                                
                            }                                          
                        }
                    }
                        StringBuilder sb = new StringBuilder();
                        sb.Append(word2);
                        sb.Insert(set2, ">");
                        tmp2 = word2;
                        tmp2 = sb.ToString();
                        Console.WriteLine(tmp2);
                        Console.ReadKey();                               
                    }                   
                }
            }
        }
    }
