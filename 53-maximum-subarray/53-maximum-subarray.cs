public class Solution {
    public int MaxSubArray(int[] nums) {
        List<int> subarray=new List<int>();
        int msf=int.MinValue , meh=0 ; 
        int s=0;
        for(int i=0;i<nums.Length;i++){ 
            meh+=nums[i]; 
            
            if(meh>msf)
            { 
                subarray.Clear();
                msf=meh; 
                subarray.Add(s); 
                subarray.Add(i); 
            } 
            if(meh<0)
            {
                meh=0; 
                s=i+1;
                
            } 
        } 
 
        return msf; 
    }
}