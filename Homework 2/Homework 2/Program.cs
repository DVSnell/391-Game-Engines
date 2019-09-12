using System; //Imports (libraries)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main()
        {
            //  Establish and assign variables, arrays, and the like.
            const int ageMachine = 34;

            //  Simple Machine/User interactions start here.
            Console.WriteLine("Greetings, User.  By what name do you wish to be called?");
            Player.playerName = Console.ReadLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("It is a pleasure to meet you " + Player.playerName + ".");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("I hope you don't find it too forward of me, but I must inquire as to your age.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("How old are you?");

            //  Catch and convert the string of a user's age to an integer.
            Int32.TryParse(Console.ReadLine(), out Player.ageUser);
            System.Threading.Thread.Sleep(1500);
            Player.ageSum = ageMachine + Player.ageUser;

            //  More interactions.
            if (Player.ageUser == ageMachine)
            {
                Console.WriteLine("Neat!  I am also " + ageMachine + "!");
            }
            else
            {
                Console.WriteLine("Interesting.  I'm " + ageMachine + " years old.  I hear " + Player.ageUser + " is a fun age.");
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Did you know that when our ages are added together, we get " + Player.ageSum + "?");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Do you like to play games, " + Player.playerName + ".");
            Console.Write("Please press Y for Yes and N for No: ");
            String gameEmotion = Console.ReadLine();

            //  First Exit Possiblity.
            if (string.Equals(gameEmotion, "Y", StringComparison.OrdinalIgnoreCase))
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Great!  I like to play games, too.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("What is your favorite game?");
                Player.favGame = Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(Player.favGame + " sounds like an interesting game.  You'll have to tell me more about it.");
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

                    //  Make our math question arrays and populate them with random addends.  Also declares difficulty.
                    Addend.Addends();

                    //  Populate our answers array.
                    Answers.Sums();


                    //  Our end-state after reaching 10 questions asked.  Includes score total and an ending message.
                    Console.WriteLine("Okay, " + Player.playerName + ", I'm tallying up your answers.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("It looks like you got " + Player.score + " out of 10 correct!");
                    if (Player.score == 10)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("A perfect score, " + Player.playerName + "!  Truly amazing!");
                    }
                    if (Player.score <= 9 && Player.score >= 5)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Not bad, " + Player.playerName + ", but I think you can do better!");
                    }
                    if (Player.score <= 4)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Well that's not good.  I hope you do better next time, " + Player.playerName + "!");
                    }

                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();

                    //  Display Scoreboard
                    Scoreboard.Scores();
                }

                //  Second Exit Point's result, if taken.
                else
                {
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Ok.  Have a nice day, " + Player.playerName + "!");
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
            }

            //  First Exit Point's result, if taken.
            else
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Ok.  Well, it was a pleasure talking to you, " + Player.playerName + ".  Thank you and I hope you have a great day!");
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
