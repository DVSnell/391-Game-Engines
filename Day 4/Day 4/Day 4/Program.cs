using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionAnswer myQA = new QuestionAnswer("What is 2+3?", 5);

            Console.WriteLine(myQA.getQuestion());
            Console.WriteLine(myQA.getAnswer());
            Console.ReadLine();

        }
    }
}
