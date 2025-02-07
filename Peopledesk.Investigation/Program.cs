namespace Peopledesk.Investigation;

public class Solution {
    public int FirstUniqChar(string s)
    {
        var d = s
            .GroupBy(x=>x)
            .Where(x=>x.Count() == 1)
            .ToDictionary(x => x.Key , x=>x.Count());

        if (!d.Any()) return -1;
        var firstUniqueChar = d.First().Key;
        return s.IndexOf(firstUniqueChar);
        
    }
}

internal static class Program
{
    private static void Main()
    {
        Solution s = new();

        var str = "leetcode" ; 

        Console.WriteLine(s.FirstUniqChar(str));
    }
}
