using System.Collections.Generic;
using System.Linq;

namespace Algorithms.LeetCode
{
    public static class Sudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            var squareVals = new HashSet<char>[3, 3];

            //scan rows & columns
            for (int i = 0; i < board.Length; i++)
            {
                var columnVals = new HashSet<char>();
                var rowVals = new HashSet<char>();

                for (int j = 0; j < board[i].Length; j++)
                {
                    //row check
                    if (board[i][j] != '.')
                    {
                        if (!rowVals.Add(board[i][j]))
                        {
                            return false;
                        }

                        //square check
                        var squarex = i / 3;
                        var squarey = j / 3;
                        if (squareVals[squarex, squarey] == null)
                        {
                            squareVals[squarex, squarey] = new HashSet<char>();
                        }

                        if (!squareVals[squarex, squarey].Add(board[i][j]))
                        {
                            return false;
                        }
                    }

                    //column check
                    if (board[j][i] != '.')
                    {
                        if (!columnVals.Add(board[j][i]))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}