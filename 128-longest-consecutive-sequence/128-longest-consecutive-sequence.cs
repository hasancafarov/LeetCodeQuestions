public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashSet = new HashSet<int> ();
        foreach (int num in nums) {
            hashSet.Add(num);
        }

        int longestStreak = 0;

        foreach (int num in nums) {
            if (!hashSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                while (hashSet.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;

    }
}