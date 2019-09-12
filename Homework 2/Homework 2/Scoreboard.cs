using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class Scoreboard
    {
        static public int[] rank = new int[10];
        static public String[] name = new string[10];
        static public int[] score = new int[10];
        static public int n = 0;
        static public int s = 0;

        static public void Scores()
        {
            Console.WriteLine("Here are the current high scores:");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(name[n] + " got a score of " + score[s]);
                n++;
                s++;
            }
            name[n] = Player.playerName;
            score[s] = Player.score;
        }
    }
}
