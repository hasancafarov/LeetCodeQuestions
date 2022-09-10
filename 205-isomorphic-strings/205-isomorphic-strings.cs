public class Solution {
    public bool IsIsomorphic(string s, string t) {
       var dict = new Dictionary<char,char>();

    for(var i = 0; i < s.Length; i++)
    {
        if(dict.ContainsKey(s[i])){
            if(dict[s[i]] != t[i]){
                return false;
            }
        } 
        //checking if the value already exists and is mapped with any other key
            else if(dict.ContainsValue(t[i])){
                return false;
            }
        else
        {
            dict.Add(s[i],t[i]);
        }
    }
    return true;
    }
}