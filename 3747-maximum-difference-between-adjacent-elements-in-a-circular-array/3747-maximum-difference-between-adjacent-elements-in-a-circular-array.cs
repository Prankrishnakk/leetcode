public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
               int n = nums.Length;
        int maxDiff = 0;

        for (int i = 0; i < n; i++) {
            int next = (i + 1) % n; 
            int diff = Math.Abs(nums[i] - nums[next]);
            maxDiff = Math.Max(maxDiff, diff);
        }

        return maxDiff;
    }
    
}