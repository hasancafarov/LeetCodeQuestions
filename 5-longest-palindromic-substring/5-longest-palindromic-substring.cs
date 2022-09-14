public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        (int, int) result = (0, 0);
        bool[][] dp = new bool[n][];
        for (int i = 0; i < n; i++) {
            dp[i] = new bool[n];
            for (int j = i ; j  >= 0; j--) {
                dp[i][j] = i - j < 2 ? s[i] == s[j] : s[i] == s[j] && dp[i - 1][j + 1]; 
				// alternative: dp[i][j] = s[i] == s[j] && (i - j < 2 || dp[i - 1][j + 1]); 
                if (dp[i][j] && result.Item1 - result.Item2 < i - j) result = (i, j);
            }
        }
        return s.Substring(result.Item2, result.Item1 - result.Item2 + 1);

}
}