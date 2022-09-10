public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        int len=nums.Length;
        for(int i=0;i<len;i++){
            if(dict.ContainsKey(nums[i]))
            dict[nums[i]]++;
            else
                dict.Add(nums[i],1);
        }
        
        foreach(var item in dict){
            if(item.Value>(len/2))
                return item.Key;
        }
        return -1;
    }
}