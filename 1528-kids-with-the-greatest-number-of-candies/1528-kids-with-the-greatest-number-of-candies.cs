public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new List<bool>();
        int maxCandies = candies.Max(); 

        foreach (int candy in candies) {
            
            result.Add(candy + extraCandies >= maxCandies);
        }

        return result;
    }
}
