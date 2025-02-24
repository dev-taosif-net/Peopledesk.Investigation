namespace Peopledesk.Investigation;

public class Solution {
    public void ReverseString(char[] s)
    {
        var start = 0;
        var len = s.Length;
        while (start < len)
        {
            var temp = s[start];
            s[start] = s[len - 1];
            s[len - 1] = temp;
        }
        
    }
}
internal static class Program
{
    private static void Main()
    {

    }
}
