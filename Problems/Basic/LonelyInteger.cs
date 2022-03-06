namespace HackerRank_Solutions.Problems.Basic;
public class LonelyInteger
{
    public LonelyInteger()
    {
        Console.Write("Enter size of array:");
        int size = Convert.ToInt32(Console.ReadLine().Trim());
        while (size % 2 == 0)
        {
            Console.WriteLine("Please Enter odd number:");
            size = Convert.ToInt32(Console.ReadLine().Trim());
        }

        List<int> arr = null;
        while (arr is null || arr.Count != size)
        {
            Console.WriteLine("Please Enter arrays with space sperates:");
            arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            if (arr.Count != size)
                Console.WriteLine($"sizes is diffrenet, enter array with true size:{size}.");
        }

        Console.WriteLine($"The element that occurs only once: {lonelyinteger(arr)}");
    }

    private int lonelyinteger(List<int> arr)
    {
        /* 
         Binary Search: 
           1. array must be sorted
           2. if all elements accure twice:
              - from left to right : the first number in even index and its duplicate be in odd index
              - from right to left : number in odd and duplicate be in even 
        */
        arr.Sort();
        int low = 0, high = arr.Count() - 2;
        int mid;

        while (low < high)
        {
            mid = (low + high) / 2;
            if (mid % 2 != 0)
                mid++;
            //assume start from left to right, (int)mid should be even 
            //so, assume the mid fall in left side, its duplicate is mid+1
            //if true-> no unique number in left side,   so low  = mid+2
            //if not -> unique number fall in left side, so high = mid-1 (to compare mid with  mid-1 in next iteration)
            if (mid % 2 != 0)
                mid++;

            if (arr[mid] == arr[mid + 1])
            {
                low = mid + 2;
            }
            else
            {
                high = mid - 1;
            }
        }

        return arr[low];
    }
}


