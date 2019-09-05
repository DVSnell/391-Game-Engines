using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] addendA = new int[10];
            for (int i = 0; i < addendA.Length; i++)
            {
                Random randomA = new Random();
                int randomAddendA = randomA.Next(0, 50);
                addendA[i] = randomAddendA;
                System.Threading.Thread.Sleep(500);
            }
            for (int i = 0; i < addendA.Length; i++)
            {
                Console.WriteLine(addendA[i]);
            }

            Console.WriteLine();
            System.Threading.Thread.Sleep(500);

            int[] addendB = new int[10];
            for (int i = 0; i < addendB.Length; i++)
            {
                Random randomB = new Random();
                int randomAddendB = randomB.Next(0, 50);
                addendB[i] = randomAddendB;
                System.Threading.Thread.Sleep(500);
            }
            for (int i = 0; i < addendB.Length; i++)
            {
                Console.WriteLine(addendB[i]);
            }

            Console.WriteLine();

            int[] questionSum = new int[10];
            for (int i = 0; i < questionSum.Length; i++)
            {
                int n = 0;
                for (int v = 0; v < 10; v++)
                {
                    questionSum[n] = addendA[n] + addendB[n];
                    Console.WriteLine("What is " + addendA[n] + "+" + addendB[n] + "?");
                    Console.ReadLine();
                    n++;
                }
            }
            for (int i = 0; i < questionSum.Length; i++)
            {
                Console.WriteLine(questionSum[i]);
            }


        }
    }
}
