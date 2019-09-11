using System; //Imports (libraries)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playtime_101
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Establish and assign variables, arrays, and the like.
            int score = 0;
            const int ageMachine = 34;
            string playerName = "Name";
            int ageUser = 0;
            int ageSum = 0;
            string favGame = "Game";
            int difficulty = 20;
            int[] addendA = new int[10];
            int[] addendB = new int[10];
            int[] questionSum = new int[10];
            String[] rightAnswer = { "Great!", "Good job!", "Fantastic!", "Superb!", "Outstanding!", "Yes!" };
            String[] wrongAnswer = { "Oh no!", "Yikes!", "So close!", "Uh oh!", "Aw nuts!", "Oops!" };

            //  Simple Machine/User interactions start here.
            Console.WriteLine("Greetings, User.  By what name do you wish to be called?");
            playerName = Console.ReadLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("It is a pleasure to meet you " + playerName + ".");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I hope you don't find it too forward of me, but I must inquire as to your age.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("How old are you?");

            //  Catch and convert the string of a user's age to an integer.
            Int32.TryParse(Console.ReadLine(), out ageUser);
            System.Threading.Thread.Sleep(1500);
            ageSum = ageMachine + ageUser;

            //  More interactions.
            if (ageUser == ageMachine)
            {
                Console.WriteLine("Neat!  I am also " + ageMachine + "!");
            }
            else
            {
                Console.WriteLine("Interesting.  I'm " + ageMachine + " years old.  I hear " + ageUser + " is a fun age.");
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Did you know that when our ages are added together, we get " + ageSum + "?");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Do you like to play games, " + playerName + ".");
            Console.Write("Please press Y for Yes and N for No: ");
            String gameEmotion = Console.ReadLine();

            //  First Exit Possiblity.
            if (string.Equals(gameEmotion, "Y", StringComparison.OrdinalIgnoreCase))
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Great!  I like to play games, too.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("What is your favorite game?");
                favGame = Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(favGame + " sounds like an interesting game.  You'll have to tell me more about it.");
                Console.WriteLine();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Would you like to play a little math game with me?");
                Console.Write("Please press Y for Yes and N for No: ");
                String gameState = Console.ReadLine();
                Console.WriteLine();

                //  Second Exit Point and game start.
                if (string.Equals(gameState, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Excellent!  Let's get started!");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("I'm going to ask you ten questions and you just need to answer them as best as you can.");

                    //  Difficulty determined by user age.  Limits the random numbers from our addends to 0-20 if the user's age is equal to or under 14.  Allows the random addends to go up to 100 if user age is over 14.
                    if (ageUser >= 14)
                    {
                        difficulty = 101;
                    }
                    else
                    {
                        difficulty = 21;
                    }

                    //  Make our math question arrays and populate them with random addends.
                    for (int i = 0; i < addendA.Length && i < addendB.Length; i++)
                    {
                        Random randomA = new Random();
                        int randomAddendA = randomA.Next(difficulty);
                        addendA[i] = randomAddendA;
                        System.Threading.Thread.Sleep(25);
                        Random randomB = new Random();
                        int randomAddendB = randomB.Next(difficulty);
                        addendB[i] = randomAddendB;
                        System.Threading.Thread.Sleep(25);
                    }
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Here is your first question:");
                    System.Threading.Thread.Sleep(2000);

                    //  Populate Answer array by adding our randomly generated addends and storing the result.
                    for (int i = 0; i < questionSum.Length; i++)
                    {
                        questionSum[i] = addendA[i] + addendB[i];
                    }

                    //  Ask only 10 questions
                    for (int v = 0; v < 10; v++)
                    {

                        //  Record our answers, convert them to an int and compare to our answer array.
                        Console.WriteLine("What is " + addendA[v] + "+" + addendB[v] + "?");
                        int[] userAnswerEntry = new int[10];
                        int userAnswerInt = Int32.Parse(Console.ReadLine());
                        if (userAnswerInt == questionSum[v])
                        {

                            //  Answers that are correct pull from a string array for a response, add to the score and prep for next question.
                            System.Threading.Thread.Sleep(2000);
                            Random success = new Random();
                            int correct = success.Next(rightAnswer.Length);
                            Console.WriteLine(rightAnswer[correct] + "  " + addendA[v] + "+" + addendB[v] + " does equal " + questionSum[v] + "!");
                            score++;
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {

                            //  Incorrect answers pull from a different string array and prep for the next question
                            System.Threading.Thread.Sleep(2000);
                            Random failure = new Random();
                            int incorrect = failure.Next(wrongAnswer.Length);
                            Console.WriteLine(wrongAnswer[incorrect] + "  " + addendA[v] + "+" + addendB[v] + " actually equals " + questionSum[v] + "!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }

                    //  Our end-state after reaching 10 questions asked.  Includes score total and an ending message.
                    Console.WriteLine("Okay, " + playerName + ", I'm tallying up your answers.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("It looks like you got " + score + " out of 10 correct!");
                    if (score == 10)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("A perfect score, " + playerName + "!  Truly amazing!");
                    }
                    if (score <= 9 && score >= 5)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Not bad, " + playerName + ", but I think you can do better!");
                    }
                    if (score <= 4)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Well that's not good.  I hope you do better next time, " + playerName + "!");
                    }
                }

                //  Second Exit Point's result, if taken.
                else
                {
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Ok.  Have a nice day, " + playerName + "!");
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
            }

            //  First Exit Point's result, if taken.
            else
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Ok.  Well, it was a pleasure talking to you, " + playerName + ".  Thank you and I hope you have a great day!");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            //  Some polite exit dialog.
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Well, I hope you had fun playing my little game.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Come back soon and play again!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Good bye!");
            System.Threading.Thread.Sleep(2000);
            return;
        }
    }
}
