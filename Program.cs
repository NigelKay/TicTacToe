using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int playerTurn = 0;
            String[] boardSelections = { "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int games = 0;
            int playerOneWins = 0;
            int playerTwoWins = 0;
            int ties = 0;
            bool gameOn = true;

            //Welcome text
            Console.WriteLine(Board.Draw(boardSelections));
            Console.WriteLine();
            Console.WriteLine("Welcome to Tic Tac Toe!");

            //Choose chip
            String playerOneChip = Player.ChooseChip();
            String playerTwoChip = playerOneChip == "X" ? "O" : "X";

            //Turn decider
            Random rnd = new Random();
            playerTurn = rnd.Next(1,3);
            Console.WriteLine("Player {0} is going first!",playerTurn);

            //game loop
            while (gameOn)
            {
                if (playerTurn == 1)
                //Player 1 turn
                {
                    //Check if board is full
                    if (!Board.FullBoardCheck(boardSelections))
                    {
                        Console.Clear();
                        Console.WriteLine(Board.Draw(boardSelections));
                        int playerOneChoice = Player.ChoosePosition(1);

                        //Check to see if selection is legal
                        if (Board.EmptySpaceCheck(playerOneChoice, boardSelections))
                        {
                            //assign choice
                            boardSelections[playerOneChoice] = playerOneChip;
                            Console.Clear();
                            Console.WriteLine(Board.Draw(boardSelections));
                            Console.WriteLine();

                            if (Board.WinCheck(boardSelections, playerOneChip))
                            {
                                Console.WriteLine("Player 1 has won!!!");
                                playerOneWins++;
                                Console.WriteLine();
                                boardSelections = Board.Clear(boardSelections);
                                playerTurn = rnd.Next(1, 3);
                                gameOn = Game.Replay();

                            }
                            else
                            {
                                //switch turn
                                playerTurn = 2;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The game is a tie!");
                        Console.WriteLine();
                        boardSelections = Board.Clear(boardSelections);
                        playerTurn = rnd.Next(1, 3);
                        gameOn = Game.Replay();
                    }
                }
                else
                {
                    if (!Board.FullBoardCheck(boardSelections))
                    {
                        Console.Clear();
                        Console.WriteLine(Board.Draw(boardSelections));
                        int playerTwoChoice = Player.ChoosePosition(2);

                        if (Board.EmptySpaceCheck(playerTwoChoice, boardSelections))
                        {
                            boardSelections[playerTwoChoice] = playerTwoChip;
                            Console.Clear();
                            Console.WriteLine(Board.Draw(boardSelections));
                            Console.WriteLine();

                            if (Board.WinCheck(boardSelections, playerTwoChip))
                            {
                                Console.WriteLine("Player 2 has won!!!");
                                playerTwoWins++;
                                Console.WriteLine();
                                boardSelections = Board.Clear(boardSelections);
                                playerTurn = rnd.Next(1, 3);
                                gameOn = Game.Replay();

                            }
                            else
                            {
                                playerTurn = 1;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The game is a tie!");
                        ties++;
                        Console.WriteLine();
                        boardSelections = Board.Clear(boardSelections);
                        playerTurn = rnd.Next(1, 3);
                        gameOn = Game.Replay();
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine();
            games = playerOneWins + playerTwoWins + ties;

            if (playerOneWins > playerTwoWins)
            {
                Console.WriteLine("You played {0} games, Player One is the overall winner. Stats below:",games);
            }
            else if (playerOneWins < playerTwoWins)
            {
                Console.WriteLine("You played {0} games, Player Two is the overall winner. Stats below:",games);
            }
            else
            {
                Console.WriteLine("You played {0} games. Overall, it was a tie! Stats below:",games);
            }

            Console.WriteLine("Player One Wins:"+playerOneWins);
            Console.WriteLine("Player Two Wins:"+playerTwoWins);
            Console.WriteLine("Tied Games:" + ties);

            Console.ReadLine();
        }
    }
}
