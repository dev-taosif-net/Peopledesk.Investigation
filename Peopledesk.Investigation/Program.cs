namespace Peopledesk.Investigation;

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }
}

internal static class Program
{
    private static void Main()
    {
        Solution s = new();

        int[] student = [1,2,2,1]; 
        int[] sandwitch = [2,2]; 
        var x = s.Intersection(student, sandwitch);

        Console.WriteLine(s.Intersection(student, sandwitch));
    }
}
