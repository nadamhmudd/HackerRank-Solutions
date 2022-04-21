using System;
using System.Text;

namespace HackerRank_Solutions.Problems.Basic
{
    public class GridChallenge
    {
        public GridChallenge()
        {
            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

               List<string> grid = new List<string>();

            //    for (int i = 0; i < n; i++)
            //    {
            //        string gridItem = Console.ReadLine();
            //        grid.Add(gridItem);
            //    }

                grid = new List<string> { "mpxz", "abcd", "wlmf" };

                string result = gridChallenge(grid);

                Console.WriteLine(result);
            //}
        }

        private static string gridChallenge(List<string> grid)
        {
            StringBuilder columnRslt = new StringBuilder();

            grid = grid.Select(row => String.Concat(row.OrderBy(c => c))).ToList();

            for (int i= 0; i < grid[0].Length; i++) {
                for (int j = 0; j < grid.Count; j++)
                {
                    columnRslt.Append(grid[j][i]);
                }

                if (!columnRslt.ToString().Equals(String.Concat(columnRslt.ToString().OrderBy(c => c))))
                {
                    return "NO";
                }

                columnRslt.Clear();
            }

            return "YES";
        }
    }
}
