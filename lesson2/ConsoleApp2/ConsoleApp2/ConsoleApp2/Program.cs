using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq.Expressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = "t";
            switch (day){
                

                case "m": Console.WriteLine("Monday"); break;
                case "t": Console.WriteLine("Thurstday"); break;
                case "w": Console.WriteLine("Wendsday"); break;
                case "th": Console.WriteLine("Thurstay"); break;
                case "f": Console.WriteLine("Friday"); break;
                default:
                    Console.WriteLine("notday");
                    break;

            }

            float var1 = 12;
            double var2 = 13;
            short var3 = 16;
            if ( var1>var2&&var1>var3)
            {
                Console.WriteLine(var1);
            } else if (var2 > var3 && var2 > var1)
            {
                Console.WriteLine(var2);
            } else 
            {
                Console.WriteLine(var3);
            }
         
          /*  long l = 12L;
            byte bt = 12;
            short sht = 13;
            if (bt < sht) {
                Console.WriteLine(bt);

            } else if (bt >= l) {
                Console.WriteLine(bt);
            } else { }
            */
                Console.WriteLine("Hello World!");
            }
        }
    }

