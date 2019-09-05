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
            //Start Arrays
            //int[] addendA = new int[10];
            //for (int i = 0; i < addendA.Length; i++)
            //{
            //    Random randomA = new Random();
            //    int randomAddendA = randomA.Next(0, 50);
            //    addendA[i] = randomAddendA;
            //    System.Threading.Thread.Sleep(25);
            //}
            //for (int i = 0; i < addendA.Length; i++)
            //{
            //    Console.WriteLine(addendA[i]);
            //}

            //Console.WriteLine();
            //System.Threading.Thread.Sleep(25);

            //int[] addendB = new int[10];
            //for (int i = 0; i < addendB.Length; i++)
            //{
            //    Random randomB = new Random();
            //    int randomAddendB = randomB.Next(0, 50);
            //    addendB[i] = randomAddendB;
            //    System.Threading.Thread.Sleep(25);
            //}
            //for (int i = 0; i < addendB.Length; i++)
            //{
            //    Console.WriteLine(addendB[i]);
            //}

            //Console.WriteLine();


            //Consolidation of Arrays
            int[] addendA = new int[10];
            int[] addendB = new int[10];
            for (int i = 0; i < addendA.Length && i < addendB.Length; i++)
            {
                Random randomA = new Random();
                int randomAddendA = randomA.Next(50);
                addendA[i] = randomAddendA;
                System.Threading.Thread.Sleep(25);
                Random randomB = new Random();
                int randomAddendB = randomB.Next(50);
                addendB[i] = randomAddendB;
                System.Threading.Thread.Sleep(25);
            }
            for (int i = 0; i < addendA.Length; i++)
            {
                Console.WriteLine(addendA[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < addendB.Length; i++)
            {
                Console.WriteLine(addendB[i]);
            }

            Console.WriteLine();
            System.Threading.Thread.Sleep(25);

            //  EXPERIMENTAL NOISE DOWN BELOW
            //  The plan was to then generate questions from the question arrays,
            //  recieve answers from the user, cross-reference with the stored 
            //  answers and increment a variable that would drive both question/array
            //  progression, a total questions asked counter, and a score counter.
            //  Finally, after the total questions asked counter hit 10, it would stop 
            //  and display a score

            Console.WriteLine();
            int[] questionSum = new int[10];
            for (int i = 0; i < questionSum.Length; i++)
            {
                for (int v = 0; v < 10; v++)
                {
                    questionSum[v] = addendA[v] + addendB[v];
                    Console.WriteLine("What is " + addendA[v] + "+" + addendB[v] + "?");
                    //int[] userAnswerEntry = new int[10];
                    //int userAnswerInt = Int32.Parse(Console.ReadLine());
                    //userAnswerEntry = Console.ReadLine();
                    //Int32.TryParse(userAnswerEntry, out userAnswerInt);
                    //if (userAnswerInt == questionSum[n])
                }
            }
            for (int i = 0; i < questionSum.Length; i++)
            {
                Console.WriteLine(questionSum[i]);
            }

            Console.ReadLine();
            //int[] myAnswerArray = new int[5];
            //String[] myQuestionArray = new string[5];
        }
    }
}
