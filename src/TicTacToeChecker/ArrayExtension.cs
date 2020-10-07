using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDKatas.TicTacToeChecker
{
    public static class ArrayExtension
    {
            public static int[] GetColumn(this int[,] matrix, int columnNumber)
            {
                return Enumerable.Range(0, matrix.GetLength(0))
                        .Select(x => matrix[x, columnNumber])
                        .ToArray();
            }

            public static int[] GetRow(this int[,] matrix, int rowNumber)
            {
                return Enumerable.Range(0, matrix.GetLength(1))
                        .Select(x => matrix[rowNumber, x])
                        .ToArray();
            }
    }
}
