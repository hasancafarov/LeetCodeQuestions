public class Solution {
    public int Search(int[] nums, int target) {
        int start=0;
        int end=nums.Length;
        while(start<end){
            int mid=(end+start)/2;
            if(nums[mid]==target)
                return mid;
            else if (nums[mid]<target)
                start=mid+1;
            else if (nums[mid]>target)
                end=mid;
        }
        return -1;
    }
}