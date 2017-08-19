using System;
using System.Collections.Generic;
using System.Text;

namespace C17_Ex02
{
    class UserInterfaceGame
    {
        private GameBoard m_GameBoard;
        private Player m_FirstPlayer;
        private Player m_SecondPlayer;
        private int m_AmountPlayers;

        public UserInterfaceGame(int i_size, string i_FirstPlayerName, string i_secondPlayerName, int i_AmountOfPlayers)
        {
            m_GameBoard = new GameBoard(i_size);
            m_FirstPlayer = new Player(i_FirstPlayerName);
            m_SecondPlayer = new Player(i_secondPlayerName);
            m_AmountPlayers = i_AmountOfPlayers;
        }

        private void InitGame()
        {
            m_GameBoard.InitGameBoard();
            Ex02.ConsoleUtils.Screen.Clear();   
        }

        public void ShowScore()
        {
            string scoreMsg;
            string[] args = new string[6];
            args[0] = "             SCORE:              \n";
            args[1] = "=================================\n";
            args[2] = m_FirstPlayer.PlayerName;
            args[3] = m_SecondPlayer.PlayerName;
            args[4] = m_FirstPlayer.Score.ToString();
            args[5] = m_FirstPlayer.Score.ToString();

            Ex02.ConsoleUtils.Screen.Clear();
            scoreMsg = string.Format("{0}{1}{2,10}{3,15}\n{4,8}{5,15}\n{1}", args);
            Console.WriteLine(scoreMsg);
        }

        internal void MakeAMove()
        {
            int chosenRow, chosenCol; 
            Console.Write("{0} its your torn.\nChoose a cell in the board - row then col: ");
            chosenRow = Console.Read();
            chosenCol = Console.Read();
        }
    }
}
