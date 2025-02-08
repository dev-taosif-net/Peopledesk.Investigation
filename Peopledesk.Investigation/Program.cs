namespace Peopledesk.Investigation;

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        
        int first = nums.GroupBy(x => x).Where(g => g.Count() == 2).Select(x => x.Key).First();
        int second = Enumerable.Range(1, nums.Length).Except(nums).First();

        return new int[] { first, second }; 
    }
}
internal static class Program
{
    private static void Main()
    {
        Solution s = new();

        //var str = "leetcode" ; 

        //Console.WriteLine(s.FirstUniqChar(str));
    }
}
