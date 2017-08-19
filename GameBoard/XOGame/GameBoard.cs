using System;
using System.Collections.Generic;
using System.Text;

namespace C17_Ex02
{
    class GameBoard
    {
        private char?[,] m_MatrixGameBoard;
        private int m_AmountOccupiedCells;
        private int m_BoardSize;

        public GameBoard(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            m_MatrixGameBoard = new char?[m_BoardSize, m_BoardSize];
            m_AmountOccupiedCells = 0;
        }
       
        public int AmountOccupiedCells
        {
            get { return m_AmountOccupiedCells; }
            set
            {
                if (m_AmountOccupiedCells + value <= m_MatrixGameBoard.Length)
                {
                    m_AmountOccupiedCells = value;
                }
            }
        }

        internal void InitGameBoard()
        {
            for (int i=0; i < m_BoardSize; i++)
            {
                for (int j=0; j < m_BoardSize; j++)
                {
                    m_MatrixGameBoard[i, j] = null;
                }
            }
        }
    }
}
