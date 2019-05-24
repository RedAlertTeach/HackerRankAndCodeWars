using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            // VALID GRID
            int[][] grid = new int[][] { new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                                       new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                                       new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                                       new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                                       new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                                       new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                                       new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                                       new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                                       new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9} }; 
            // INVALID GRID
        /*    int[][] grid = new int[][] { new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                                      new int[] { 6, 7, 2, 1, 9, 0, 3, 4, 8 },
                                      new int[] { 1, 0, 0, 3, 4, 2, 5, 6, 0 },
                                      new int[] { 8, 5, 9, 7, 6, 1, 0, 2, 0 },
                                      new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                                      new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                                      new int[] { 9, 0, 1, 5, 3, 7, 2, 1, 4 },
                                      new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                                      new int[] { 3, 0, 0, 4, 8, 1, 1, 7, 9} }; */
            if (ValidGrid(grid))
                Console.WriteLine("The grid is a valid solution.");
            else
                Console.WriteLine("The grid is NOT a valid solution.");
            Console.ReadLine();

        }
        static bool ValidGrid(int[][] grid)
        {
            // list of lists to hold the grid
            List<List<int>> rows = new List<List<int>>();
            List<List<int>> cols = new List<List<int>>();



            // if the grid contains any zeroes the solution is not valid
            // Build list for each row and column as we go
            for (int i = 0; i < grid.Length; i++)
            {
                List<int> row = new List<int>();
                List<int> col = new List<int>();

                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] <= 0 || grid[i][j] > 9)
                        return false;
                    else
                    {
                        row.Add(grid[i][j]);
                        col.Add(grid[j][i]);
                    }
                }
                rows.Add(row);
                cols.Add(col);
            }

            // validate each row
            foreach (var row in rows)
            { 
                if (!Valid(row.ToArray()))
                    return false;
            }
            // validate each column
            foreach (var col in cols)
            {
                if (!Valid(col.ToArray()))
                    return false;
            }

            

            // validate each 3 X 3 square
            for (int b = 0; b < 3; b++)
            {
                List<int> gridList = new List<int>();
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 3*b; c <= (3*b + 2); c++)
                    {
                        gridList.Add(rows[r][c]);
                    }
                }
                if (!Valid(gridList.ToArray()))
                    return false;

                gridList.RemoveAll(n => n > 0);
                for (int r = 3; r < 6; r++)
                {
                    for (int c = 3 * b; c <= (3 * b + 2); c++)
                    {
                        gridList.Add(rows[r][c]);
                    }
                }
                if (!Valid(gridList.ToArray()))
                    return false;

                gridList.RemoveAll(n => n > 0);
                for (int r = 6; r < 9; r++)
                {
                    for (int c = 3 * b; c <= (3 * b + 2); c++)
                    {
                        gridList.Add(rows[r][c]);
                    }
                }
                if (!Valid(gridList.ToArray()))
                    return false;
            }
            return true;
        }
        static bool Valid(int[] list)
        {
            int[] valid = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var intersect = valid.Intersect(list);
            if (intersect.Count() != valid.Count())
                return false;
            
            return true;
        }
    }
}
