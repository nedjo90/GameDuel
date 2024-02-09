using System;
using System.Collections.Generic;
using System.Threading;

namespace GameDuel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Battle duel = new Battle();
            duel.Fight();
        }

    }
}