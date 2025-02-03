namespace Peopledesk.Investigation;

public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var totalTakenTime = 0;
        totalTakenTime = tickets.Sum(x=> x > tickets[k]-1  ? tickets[k]-1 : x);
        totalTakenTime = totalTakenTime + (tickets.Take(k+1).Sum(x => x >= tickets[k]  ? 1 : 0));

        return totalTakenTime;
    }
}

internal static class Program
{
    private static void Main()
    {
        Solution s = new();

        int[] nums = [5,1,1,1]; 

        Console.WriteLine(s.TimeRequiredToBuy(nums, 0));
    }
}
