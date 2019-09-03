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
            double decimals = 0.0;
            string name = "Floop Greebyg";
            string bananaState = "Yes";

            Console.WriteLine("Please tell me your name");
            name = Console.ReadLine();

            Console.WriteLine("It is a pleasure to meet you " + name + ". My name is Don");
            Console.WriteLine("Do you like bananas?");
            bananaState = Console.ReadLine();

            Console.WriteLine("That's super interesting.");
            Console.WriteLine("Did you know I once saw a banana kill a man in Vegas."); // Writes to a line and adds return
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("He had it coming.");
            Console.ReadLine();
        }
    }
}
