using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Batting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Welcome to Batting Average Calculator!");
            Console.WriteLine();
            Console.Write("Enter Number of Times at bat: ");

            int numberOfTimesBat = int.Parse(Console.ReadLine());
            int[] result = new int[numberOfTimesBat];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Result for at bat {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

                for (int j = 0; j < numberOfTimesBat; j++)
                {

                    sum = sum + result[j];

                }
            int hits = 0;

                     for (int k = 0; k < numberOfTimesBat; k++)
                     {
                if (result[k] != 0)
                {
                    hits++;

                }
           }

            double battingAvg = (double)hits / result.Length;
            Console.WriteLine("Batting Average: " + battingAvg);
            double avg = (double)sum / result.Length;
            Console.WriteLine("Slugging Percentage: " + avg);
        
            }
        }
    }

