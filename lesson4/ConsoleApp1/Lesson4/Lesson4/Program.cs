using System;
using System.Collections.Generic;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
         


            List<string> l = new List<string>() { "Break", "English", "watch film", "sit in home" };

            //l.Add("Break,English,watch film,sit in home);
            foreach (string p in l)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(l[0]);

            Console.WriteLine(l.Count);

            l.Clear();
            // string l.add("Break,Englist");


           
            }
        }
    }
