namespace HackerRank_Solutions.Problems.Basic;
public class PlusMinus
{
    public PlusMinus()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        plusMinus(arr);
    }

    private void plusMinus(List<int> arr)
    {
        int posCount = 0, negCount = 0, zeroCount = 0;
        int size = arr.Count();
        foreach (var number in arr)
        {
            if (number > 0)
                posCount++;
            else if (number < 0)
                negCount++;
            else
                zeroCount++;
        }

        Console.WriteLine(@"{0:F6}
{1:F6}
{2:F6}
", (double)posCount / size, (double)negCount / size, (double)zeroCount / size);

    }
}


