using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex02_01.GameLogic
{
    public enum eTypeOfPlayer
    {
        Human,
        Computer
    }

    public class Player
    {
        private string m_PlayerName;

        private int m_PlayerCurrentScore;

        private readonly eTypeOfPlayer m_TypeOfPlayer;

        /// <summary>
        /// the player
        /// is a computer 
        /// type
        /// </summary>
        public Player()
        {
            m_PlayerCurrentScore = 0;
            m_PlayerName = "Computer";
            m_TypeOfPlayer = eTypeOfPlayer.Computer;
        }

        /// <summary>
        /// the player is
        /// a human type
        /// </summary>
        /// <param name="i_PlayerName"></param>
        public Player(string i_PlayerName)
        {
            m_PlayerCurrentScore = 0;
            m_PlayerName = i_PlayerName;
            m_TypeOfPlayer = eTypeOfPlayer.Human;
        }

        public string PlayerName
        {
            get { return m_PlayerName; }

            set
            {

            }
        }

        public int PlayerCurrentScore
        {
            get { return m_PlayerCurrentScore; }

            set { m_PlayerCurrentScore = value; }
        }

        public eTypeOfPlayer TypeOfPlayer
        {
            get { return m_TypeOfPlayer; }
        }
    }
}
