using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Game
    {
        public static bool Replay()
        {
            Console.Write("Play again? (Y/N): ");
            String playerAnswer = Console.ReadLine().ToLower();

            if (playerAnswer[0] == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
