public class Solution {
    public int[] RunningSum(int[] nums) {
         int i = 1;
        while (i<nums.Length){
            nums[i]+=nums[i-1];
            i++;
        }
        return nums;
    }
}