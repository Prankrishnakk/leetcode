public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int>sets = new HashSet<int>();

        foreach(int num in nums)
        {
            if(!sets.Add(num))
            {
                sets.Remove(num);
            }
        }
        return sets.First();
        
    }
}