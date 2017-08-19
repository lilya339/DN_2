using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameBoard
{
    public class GameBoardGeneric<T> where T  :struct
    {
        private T?[,] m_MatrixGameBoard;

        private int m_AmountOccupiedCells;

        private int m_BoardSize;

        public GameBoardGeneric(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            m_MatrixGameBoard = new T?[m_BoardSize, m_BoardSize];
            m_AmountOccupiedCells = 0;
            InitGameBoard();
        }

        public int BoardSize
        {
            get { return m_BoardSize; }
        }

        public int AmountOccupiedCells
        {
            get { return m_AmountOccupiedCells; }
        }

        internal void InitGameBoard()
        {
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_MatrixGameBoard[i, j] = null;
                }
            }
        }

        public void DisplayGameBoard()
        {
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    Console.Write(m_MatrixGameBoard[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void InitialCell(int i_Row, int i_Column, T? i_Value)
        {
            if (IsPostionValid(i_Row, i_Column) == true)
            {
                if(m_MatrixGameBoard[i_Row, i_Column] == null)
                {
                    m_MatrixGameBoard[i_Row, i_Column] = i_Value;
                    ++m_AmountOccupiedCells;
                }
                else
                {
                    throw new Exception("The Cell is occupid.");
                }
            }

        }

        internal bool IsPostionValid(int i_Row, int i_Column)
        {
            if(i_Row >= 0 && i_Row < m_BoardSize && i_Column >= 0 && i_Column < m_BoardSize)
            {
                return true;
            }
            else
            {
                throw new Exception("The input of row or column are invalid.");
            }
        }
    }
}
