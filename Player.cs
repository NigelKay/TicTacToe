using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Player
    {
        public static string ChooseChip()
        {
            String choice = "";
            do
            {
                Console.Write("Player 1, choose a chip! X or O: ");
                choice = Console.ReadLine().ToUpper();
                if (choice == "X" || choice == "O")
                {
                    break;
                }
            } while (choice != "X" || choice != "O");
            return choice;
        }

        public static int ChoosePosition(int player)
        {
            int choice = 0;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write("Player {0}, pick a position: ", player);
                String input = Console.ReadLine();
                var isNumeric = int.TryParse(input, out choice);
                if (isNumeric)
                {
                    if (choice < 10 && choice > 0)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            return choice;

        }
    }
}
