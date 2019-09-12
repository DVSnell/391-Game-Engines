using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class Addend
    {
        static public int[] addendA = new int[10];
        static public int[] addendB = new int[10];

        static public void Addends()
        {
            if (Player.ageUser >= 14)
            {
                Player.difficulty = 101;
            }
            else
            {
                Player.difficulty = 21;
            }
            for (int i = 0; i < addendA.Length && i < addendB.Length; i++)
            {
                Random randomA = new Random();
                int randomAddendA = randomA.Next(Player.difficulty);
                addendA[i] = randomAddendA;
                System.Threading.Thread.Sleep(25);
                Random randomB = new Random();
                int randomAddendB = randomB.Next(Player.difficulty);
                addendB[i] = randomAddendB;
                System.Threading.Thread.Sleep(25);
            }
        }
    }
}
