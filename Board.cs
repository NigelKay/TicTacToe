using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Board
    {
        public static String Draw(String[] pieces)
        {
            return ("[ " + pieces[7] + " ][ " + pieces[8] + " ][ " + pieces[9] + " ]\n" +
                "[ " + pieces[4] + " ][ " + pieces[5] + " ][ " + pieces[6] + " ]\n" +
                "[ " + pieces[1] + " ][ " + pieces[2] + " ][ " + pieces[3] + " ]");
        }

        public static bool EmptySpaceCheck(int choice, String[] pieces)
        {
            //return whether the chosen space is empty.
            return pieces[choice] != "X" && pieces[choice] != "O";
        }

        public static bool WinCheck(String[] pieces, String playerChip)
        {
            return playerChip == pieces[1] && playerChip == pieces[2] && playerChip == pieces[3] ||
                playerChip == pieces[4] && playerChip == pieces[5] && playerChip == pieces[6] ||
                playerChip == pieces[7] && playerChip == pieces[8] && playerChip == pieces[9] ||
                playerChip == pieces[1] && playerChip == pieces[4] && playerChip == pieces[7] ||
                playerChip == pieces[2] && playerChip == pieces[5] && playerChip == pieces[8] ||
                playerChip == pieces[3] && playerChip == pieces[6] && playerChip == pieces[9] ||
                playerChip == pieces[1] && playerChip == pieces[5] && playerChip == pieces[9] ||
                playerChip == pieces[3] && playerChip == pieces[5] && playerChip == pieces[7];
        }

        public static bool FullBoardCheck(String[] pieces)
        {
            for (int i = 1; i < 10; i++)
            {
                if (pieces[i] != "X" && pieces[i] != "O")
                {
                    return false;
                }
            }
            return true;
        }

        public static String[] Clear(String[] pieces)
        {
            for (int i = 0; i < 10; i++)
            {
                pieces[i] = i.ToString();
            }
            return pieces;
        }
    }
}
