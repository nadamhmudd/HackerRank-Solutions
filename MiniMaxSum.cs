namespace HackerRank_Solutions;

public class MiniMaxSum
{
    public MiniMaxSum()
    {
        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
        miniMaxSum(arr);
    }

    private void miniMaxSum(List<long> arr)
    {
        var minList = arr.OrderBy(x => x).ToList();
        var maxList = new List<long>(minList);
        maxList.Reverse();

        minList.RemoveAt(minList.Count - 1);
        maxList.RemoveAt(maxList.Count - 1);

        Console.WriteLine($"{minList.Sum()} {maxList.Sum()}");
    }
}
