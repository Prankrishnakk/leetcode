public class Solution {
    public bool IsPalindrome(int x) {
         string numStr = x.ToString();
        string revStr = new string(numStr.Reverse().ToArray());
        return numStr == revStr;

    }

    public void Main()
    {
        Console.WriteLine(IsPalindrome(10)); 
        Console.WriteLine(IsPalindrome(121)); 
    }
}
