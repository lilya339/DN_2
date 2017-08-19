using System;
using System.Collections.Generic;
using System.Text;

namespace C17_Ex02
{
    public class Program
    {
        public static void Main()
        { 
            UIGame();
        }

        private static void UIGame()
        {
            int boardSize;
            int amountOfPlayers;
            string firstPlayerName = null, secondPlayerName = "Computer";
            UserInterfaceGame theGame = null;

            boardSize = inputBoardSize();
            amountOfPlayers = inputAmountPlayers();
            inputPlayersName(ref firstPlayerName, ref secondPlayerName, amountOfPlayers);
            theGame = new UserInterfaceGame(boardSize, firstPlayerName, secondPlayerName, amountOfPlayers);
            theGame.printGameBoard();

            Console.ReadLine();

        }
        
        private static int inputAmountPlayers()
        {
            bool validInput = false;
            int chosenPlayer = 0;

            while (!validInput)
            {
                Console.WriteLine("Who would you like to play against to ?\n 1 - for computer 2 - for person");
                validInput = int.TryParse(Console.ReadLine(), out chosenPlayer);
                if (validInput)
                {
                    if (chosenPlayer != 1 && chosenPlayer != 2)
                    {
                        validInput = false;
                        Console.WriteLine("Error!");
                    }
                }
            }

            Console.Write("The chosen player is {0}", chosenPlayer);
            Console.ReadLine();
            return chosenPlayer;
        }

        private static int inputBoardSize()
        {
            int boardSize = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter the desirable board size batween 3-9.");
                validInput = int.TryParse(Console.ReadLine(), out boardSize);
                if (validInput)
                {
                    if (boardSize < 3 || boardSize > 9)
                    {
                        validInput = false;
                        Console.WriteLine("Error! Wrong size.");
                    }
                }
            }
            
            return boardSize;
        }

        private static void inputPlayersName(ref string i_firstName, ref string i_secondName, int i_amountOfPlayers)
        {
            Console.Write("Please enter first player name : ");
            i_firstName = Console.ReadLine();
            if (i_amountOfPlayers == 2)
            {
                Console.Write("Please enter second player name : ");
                i_secondName = Console.ReadLine();
            }
        }
    }
}
