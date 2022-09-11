public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
         int cnt = 0;
        int maxi = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                cnt++;
            } else {
                cnt = 0;
            }

            maxi = Math.Max(maxi, cnt);
        }
        return maxi;
    }
}