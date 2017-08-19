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
            string FirstPlayerName, SecondPlayerName;
            UserInterfaceGame TheGame = null;
            
            boardSize = inputBoardSize();
            InputPlayerName(out FirstPlayerName,out SecondPlayerName);
            TheGame = new UserInterfaceGame(boardSize, FirstPlayerName, SecondPlayerName);
            TheGame.ShowScore();
            Console.ReadLine();

        }
        private static int inputBoardSize()
        {
            int boardSize = 0;
            bool validSize = false, validInput = false;

            while (!validSize)
            {
                Console.WriteLine("Please enter the desirable board size batween 3-9.");
                validInput = int.TryParse(Console.ReadLine(),out boardSize);
                if (validInput)
                {
                    if (boardSize >= 3 && boardSize <= 9)
                    {
                        validSize = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! Wrong size.");
                    }
                }
            }
            
            return boardSize;
        }

        private static void InputPlayerName(out string i_firstName,out string i_secondName)
        {
            Console.Write("Please enter first player name : ");
            i_firstName=Console.ReadLine();
            Console.Write("Please enter second player name : ");
            i_secondName = Console.ReadLine();
        }
    }
}
