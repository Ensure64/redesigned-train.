using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcost = 0;
            string decision = "";
            
            
                Console.Write("welcome to MCJOHN tea house" + " ");
            START:
                Console.WriteLine("our tea comes in three size");
                Console.Write("small tea==$1, medium tea==$2, large tea==$3" + " ");
            do { 
                Console.WriteLine("please type in what size you will like for urself,");
                Console.WriteLine("please be aware that this program only accept a single space,");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "SMALL TEA":
                        totalcost += 1;
                        break;
                    case "MEDIUM TEA":
                        totalcost += 2;
                        break;
                    case "LARGE TEA":
                        totalcost += 3;
                        break;
                    default:
                        Console.WriteLine("SORRY OUR TEA ONLY COME iN SMALL, MEDIUM OR LARGE TEA");
                        goto START;

                }

                do
                {
                    Console.WriteLine("thanks for patronizing do you wish to exist ");

                    decision = Console.ReadLine().ToUpper();
                    if (!decision.Equals("YES") && !decision.Equals("NO"))
                    {
                        Console.WriteLine("please specify by entering either yes or no");
                    }
                } while (!decision.Equals("YES") && !decision.Equals("NO"));
            } while (decision == "NO");
            Console.Write("ENJOY UR TEA AND HAVE A GREAT TIME "+" ");
            Console.WriteLine("your bill amount is " + "$ " + totalcost);
            Console.WriteLine("PRESS ANY KEY TO CLOSE THIS CODE");
           
            Console.ReadKey();
        }
    }
}
