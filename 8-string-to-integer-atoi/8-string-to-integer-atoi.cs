public class Solution {
    public int MyAtoi(string s) {
        
       // 1. Advance leading whitespace
        var index = 0;        
        while (index < s.Length && char.IsWhiteSpace(s[index])) {
            ++index;
        }
        
        // 2. Determine if number is positive or negative
        var sign = 1;
        if (index < s.Length && (s[index] == '-' || s[index] == '+')) {
            if (s[index] == '-') {
                sign = -1;
            }
            ++index;
        }
        
        // 3. Convert char digits to numeric value
        var result = 0;
        while (index < s.Length && char.IsDigit(s[index])) {
            var digit = CharToInt(s[index]);
            // Check for overflow
            if (result > (int.MaxValue - digit) / 10) {
                return sign == -1 ? int.MinValue : int.MaxValue;
            }                 
            result = (result * 10) + digit;
            ++index;
        }
        return result * sign;
    }
    
    private static int CharToInt(char ch) {
        return ch - '0';
    }

}