using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDKatas.TicTacToeChecker
{
    public class TicTacToe
    {

        public int CheckBoard(int[,] board)
        {
            var result = -1;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                result = GetLineStatus(board.GetRow(i));
                if (result > 0)
                    return result;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                result = GetLineStatus(board.GetColumn(i));
                if (result > 0)
                    return result;
            }
            for (int i = 0; i < 2; i++)
            {
                result = GetLineStatus(board.GetDiagonals().GetRow(i));
                if (result > 0)
                    return result;
            }
            return (board.Cast<int>().Contains(0) ? -1:  0 );
        }


        private int GetLineStatus(int[] array)
        {
            return array.Distinct().Count() == 1 && array[0] !=0 ? array[0] : -1;
        }

    }
}
