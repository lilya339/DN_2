using C17_Ex02.GameLogic;
using System;

/// <summary>
/// tuta
/// </summary>
namespace C17_Ex02.UIConsole
{
    public class Program
    {
        public static void Main()
        {
            GameBoardGeneric<char> test = new GameBoardGeneric<char>(5);
            test.InitialCell(1, 1, 'x');
            test.DisplayGameBoard();
        }
    }
}
