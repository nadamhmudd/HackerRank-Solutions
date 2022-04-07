namespace HackerRank_Solutions.Problems.Basic
{
    public class CountingSort1
    {
        public CountingSort1()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            countingSort(arr);
        }

        private List<int> countingSort(List<int> arr)
        {
            int[] countingArr = new int[100];

            for(int i = 0; i < arr.Count; i++)
                countingArr[arr[i]]++;

            return countingArr.ToList();
        }
    }
}
