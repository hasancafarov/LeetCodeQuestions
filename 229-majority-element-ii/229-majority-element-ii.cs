public class Solution {
    public IList<int> MajorityElement(int[] nums) {
    int number1 = -1, number2 = -1, count1 = 0, count2 = 0, len = nums.Length;
    for (int i = 0; i < len; i++) {
      if (nums[i] == number1)
        count1++;
      else if (nums[i] == number2)
        count2++;
      else if (count1 == 0) {
        number1 = nums[i];
        count1 = 1;
      } else if (count2 == 0) {
        number2 = nums[i];
        count2 = 1;
      } else {
        count1--;
        count2--;
      }
    }
    List<int> ans = new List<int> ();
    count1 = 0;
    count2 = 0;
    for (int i = 0; i < len; i++) {
      if (nums[i] == number1)
        count1++;
      else if (nums[i] == number2)
        count2++;
    }
    if (count1 > len / 3)
      ans.Add(number1);
    if (count2 > len / 3)
      ans.Add(number2);
    return ans;
    }
}