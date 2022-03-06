namespace HackerRank_Solutions.Problems.Basic;
public class TimeConversion
{
    public TimeConversion()
    {
        string s = Console.ReadLine();
        Console.WriteLine(timeConversion(s));
    }
    public static string timeConversion(string s)
    {
        var timeSplitted = s.TrimEnd().Split(':').ToList(); // [h,m,sPM/Am]

        var sign = String.Join("", timeSplitted[2].ToList().Skip(2).Take(2)); //split PM or AM
        timeSplitted[2] = String.Join("", timeSplitted[2].ToList().Take(2));

        timeSplitted[0] = (sign == "AM" && timeSplitted[0] == "12") ? "00" :
                            (sign == "PM" && timeSplitted[0] != "12") ?
                                   (12 + Convert.ToInt32(timeSplitted[0])).ToString() : timeSplitted[0];

        return String.Join(":", timeSplitted);
    }
}
