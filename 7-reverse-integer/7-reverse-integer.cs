public class Solution {
    public int Reverse(int x) {
        int reversed = 0;
        for(int pop = 0, push = 0; x != 0; x /= 10)
        {
            unchecked 
            {
                pop = x % 10;
                push = reversed * 10 + pop;
                if((push-pop)/10 != reversed) 
                   return 0;
                reversed = push;
            }
        }
        return reversed;

    }
}