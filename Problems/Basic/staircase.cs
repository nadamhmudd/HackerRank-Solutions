using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions.Problems.Basic
{
    public class Staircase
    {

        public Staircase()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            staircase(n);
        }

        private void staircase(int n)
        {
            StringBuilder steps = new StringBuilder(String.Empty);

            for (int i=1; i <= n; i++)
            {
                steps.Append(' ', n - i);
                steps.Append('#',i);

                Console.WriteLine(steps);
                steps.Clear();
            }
        }
    }
}
