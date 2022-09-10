public class Solution {
    public void NextPermutation(int[] nums) {
     if(nums == null || nums.Length <= 1) return;
        int i = nums.Length - 2;
        while(i >= 0 && nums[i] >= nums[i + 1]) i--; 
        if(i >= 0) {                           
            int j = nums.Length - 1;              
            while(nums[j] <= nums[i]) j--;      
            swap(nums, i, j);                     
        }
        reverse(nums, i + 1, nums.Length - 1);      
}

public void swap(int[] A, int i, int j) {
    int tmp = A[i];
    A[i] = A[j];
    A[j] = tmp;
}

public void reverse(int[] A, int i, int j) {
    while(i < j) swap(A, i++, j--);
}
}