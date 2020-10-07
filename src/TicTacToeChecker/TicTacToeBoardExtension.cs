using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDKatas.TicTacToeChecker
{
    public static class TicTacToeBoardExtension
    {
        public static int[] GetColumn(this int[,] board, int columnNumber)
        {
            return Enumerable.Range(0, board.GetLength(0))
                    .Select(x => board[x, columnNumber])
                    .ToArray();
        }

        public static int[] GetRow(this int[,] board, int rowNumber)
        {
            return Enumerable.Range(0, board.GetLength(1))
                    .Select(x => board[rowNumber, x])
                    .ToArray();
        }
        public static int[,] GetDiagonals(this int[,] board)
        {
            return new int[,] { { board[0, 0], board[1, 1], board[2, 2] }, { board[2, 0], board[1, 1], board[0, 2] } };
        }
    }
}
