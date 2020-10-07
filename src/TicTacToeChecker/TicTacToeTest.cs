using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Extensions;

namespace TDDKatas.TicTacToeChecker
{
    public class TicTacToeTest
    {
        public static IEnumerable<object[]> PlayerWinsColumnData
        {
            get
            {
                return new[]
                {
                    new object[] { new int[,] { { 1, 2, 1 }, { 0, 0, 1 }, { 2, 1, 1 } } , 1 },
                    new object[] { new int[,] { { 0, 2, 1 }, { 1, 2, 0 }, { 1, 2, 0 } } , 2 },
                    new object[] { new int[,] { { 0,1, 0 }, { 0, 1, 1 }, { 0, 1, 2 } } , 1 },
                };
            }
        }

        public static IEnumerable<object[]> PlayerWinsRowData
        {
            get
            {
                return new[]
                {
                    new object[] { new int[,] { { 1, 1, 1 }, { 1, 2, 1 }, { 2, 1, 1 } } , 1 },
                    new object[] { new int[,] { { 1, 2, 1 }, { 2, 2, 2 }, { 2, 1, 1 } } , 2 },
                    new object[] { new int[,] { {0,0,0 }, { 1, 1, 1 }, { 2, 1, 1 } } , 1 },
                };
            }
        }
        public static IEnumerable<object[]> PlayerWinsDiagonalData
        {
            get
            {
                return new[]
                {
                    new object[] { new int[,] { { 1, 0, 0 }, { 0, 1, 1 }, { 0, 2, 1 } } , 1 },
                    new object[] { new int[,] { { 2, 0, 0 }, { 0, 2, 0 }, { 1, 1, 2 } } , 2 },
                    new object[] { new int[,] { {0,0,1 }, { 2, 1, 0 }, { 1, 0, 2 } } ,1 },
                };
            }
        }
        public static IEnumerable<object[]> NoWinData
        {
            get
            {
                return new[]
                {
                    new object[] { new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } } ,-1 },
                    new object[] { new int[,] { { 0, 1, 0 }, { 2, 0, 0 }, { 0, 1, 0 } } , -1},
                    new object[] { new int[,] { {0,0,1 }, { 0, 0, 2 }, { 0, 0, 1 } } ,-1 },
                };
            }
        }

        [Theory]
        [MemberData(nameof(PlayerWinsRowData))]

        public void CheckBoard_PlayerWinsInRow_ShouldReturnPlayerWinner(int[,] board, int expectedResult)
        {
            TicTacToe ticTacToe = new TicTacToe();

            var boardResult = ticTacToe.CheckBoard(board);

            boardResult.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(PlayerWinsColumnData))]
        public void SolveBoard_PlayerWinsInColumn_ShouldReturnPlayerWinner(int[,] board, int expectedResult)
        {
            TicTacToe ticTacToe = new TicTacToe();

            var boardResult = ticTacToe.CheckBoard(board);

            boardResult.Should().Be(expectedResult);
        }
        [Theory]
        [MemberData(nameof(PlayerWinsDiagonalData))]
        public void SolveBoard_PlayerWinsInDiagonal_ShouldReturnPlayerWinner(int[,] board, int expectedResult)
        {
            TicTacToe ticTacToe = new TicTacToe();

            var boardResult = ticTacToe.CheckBoard(board);

            boardResult.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(NoWinData))]
        public void SolveBoard_NoWin_ShouldReturnNoWin(int[,] board, int expectedResult)
        {
            TicTacToe ticTacToe = new TicTacToe();

            var boardResult = ticTacToe.CheckBoard(board);

            boardResult.Should().Be(expectedResult);
        }

    }
}
