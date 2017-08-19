using System;
using System.Collections.Generic;
using System.Text;

namespace C17_Ex02
{
    public class Player
    {
        private string m_PlayerName;
        private int m_Score;
        
        public Player(string i_Name)
        {
            m_PlayerName = i_Name;
            m_Score = 0;
        } 

        public string PlayerName
        {
            get { return m_PlayerName; }
        }

        public int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }
    }
}
