namespace Peopledesk.Investigation;

public class Solution {

    public bool IsPalindrome(string s)
    {
        var start = 0;
        var end = s.Length - 1;

        while (start < end )
        {
            while (start < end && !IsAlphanumeric(s[start])) start++;
            while (start < end && !IsAlphanumeric(s[end])) end--;
            
            if ( char.ToLower(s[start])  != char.ToLower(s[end]) )
            {
                return false;
            }
            
            start++;
            end--;
        }

        return true;
    }
    private bool IsAlphanumeric(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
    }
    
}
internal static class Program
{
    private static void Main()
    {
        var test = "A man, a plan, a canal: Panama";
        
        var solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(test));
        Console.ReadKey();

    }
}
