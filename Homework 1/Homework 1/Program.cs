using System; //Imports (libraries)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playtime_101 //groups classes together for duplicate namespace classes
{
    class Program
    {
        static void Main(string[] args) // first function, ran first, "void" = no return
        {
            int score = 0;
            const int myAge = 34;
            string playerName = "Name";
            string ageIn = "0";
            int ageOut = 0;
            int ageSum = 0;
            string favGame = "Game";

            Console.WriteLine("Greetings.  By what name do you wish to be called?");
            playerName = Console.ReadLine();

            Console.WriteLine("It is a pleasure to meet you " + playerName + ".");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("I hope you don't find it to forward of me, but I must inquire as to your age.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("How old are you?");
            ageIn = Console.ReadLine();
            Int32.TryParse(ageIn, out ageOut);
            System.Threading.Thread.Sleep(1000);
            ageSum = myAge + ageOut;

            Console.WriteLine("Fantastic.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Did you know that if we add our ages together we get " + ageSum + "?");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("I like to play games.  What is your favorite game?");
            favGame = Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(favGame +" sounds like an intersting game.  You'll have to tell me more about it later, but right now I'm wondering if you'd like to play a different game.  Would you like to play a math game with me?");

            Console.ReadLine();
        }
    }
}
