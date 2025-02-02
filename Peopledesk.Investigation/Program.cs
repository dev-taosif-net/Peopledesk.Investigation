namespace Peopledesk.Investigation;

public class Solution
{
    public int SpecialArray(int[] nums)
    {
        var count = nums.Length;
        for (var i = 0; i <= count; i++)
        {
            if (nums.Count(x => x >= i) == i )
            {
                return i;
            }
            
        }
        return -1;
    }
}

internal static class Program
{
    private static void Main()
    {
        Solution s = new();

        int[] nums = [0,4,3,0,4]; 

        Console.WriteLine(s.SpecialArray(nums));
    }
}
