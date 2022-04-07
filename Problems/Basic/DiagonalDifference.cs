namespace HackerRank_Solutions.Problems.Basic
{
    public class DiagonalDifference
    {
        public DiagonalDifference()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
                    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            diagonalDifference(arr);
        }
        /* n = 3 
         11  2  4            -> 0,0 + 1,1 + 2,2 ||||| 0,2 + 1,1 + 2,0
         4   5  6
         10  8 -12
         */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int primaryD = 0, secondaryD = 0, arrSize = arr.Count-1;

            for (int i = 0; i <= arrSize; i++)
            {
                primaryD   += arr[i][i];
                secondaryD += arr[i][arrSize - i];
            }

            return Math.Abs(primaryD - secondaryD);
        }
    }
}