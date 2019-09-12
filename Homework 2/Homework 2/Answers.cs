using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class Answers
    {
        static public String[] rightAnswer = { "Great!", "Good job!", "Fantastic!", "Superb!", "Outstanding!", "Yes!" };
        static public String[] wrongAnswer = { "Oh no!", "Yikes!", "So close!", "Uh oh!", "Aw nuts!", "Oops!" };
        static public int[] questionSum = new int[10];

        static public void Sums()
        {
            //  Populate Answer array by adding our randomly generated addends and storing the result.
            for (int i = 0; i < questionSum.Length; i++)
            {
                questionSum[i] = Addend.addendA[i] + Addend.addendB[i];
            }

            //  Ask only 10 questions
            for (int v = 0; v < 10; v++)
            {

                //  Record our answers, convert them to an int and compare to our answer array.
                Console.WriteLine("What is " + Addend.addendA[v] + "+" + Addend.addendB[v] + "?");
                int userAnswerInt = Int32.Parse(Console.ReadLine());
                if (userAnswerInt == questionSum[v])
                {

                    //  Answers that are correct pull from a string array for a response, add to the score and prep for next question.
                    System.Threading.Thread.Sleep(2000);
                    Random success = new Random();
                    int correct = success.Next(rightAnswer.Length);
                    Console.WriteLine(rightAnswer[correct] + "  " + Addend.addendA[v] + "+" + Addend.addendB[v] + " does equal " + questionSum[v] + "!");
                    Player.score++;
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {

                    //  Incorrect answers pull from a different string array and prep for the next question
                    System.Threading.Thread.Sleep(2000);
                    Random failure = new Random();
                    int incorrect = failure.Next(wrongAnswer.Length);
                    Console.WriteLine(wrongAnswer[incorrect] + "  " + Addend.addendA[v] + "+" + Addend.addendB[v] + " actually equals " + questionSum[v] + "!");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
    }
}
