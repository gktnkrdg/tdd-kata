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
            for (int i= 0; i < board.GetLength(1)   ; i++){
                result = CheckRow(board.GetRow(i));
                if (result > 0)
                    break;
            }
            return result;
        }


        private int CheckRow(int [] boardRow)
        {
            return boardRow.Distinct().Count() == 1 ? boardRow[0] : -1;
        }
    
    }
}
