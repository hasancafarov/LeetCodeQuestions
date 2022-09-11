public class Solution {
    public string ReverseVowels(string s) {
        int start = 0, end = s.Length - 1;
    char[] arr = s.ToCharArray();
    String vowels = "aeiouAEIOU";
    while(start < end) {
        while(start < end && vowels.IndexOf(arr[start]) == -1) {
            start++;
        }
        while(start < end && vowels.IndexOf(arr[end]) == -1) {
            end--;
        }
        if(start < end) {
            (arr[start],arr[end])=(arr[end],arr[start]);
            start++;
            end--;
        }
    }
    return new String(arr);
    }
}