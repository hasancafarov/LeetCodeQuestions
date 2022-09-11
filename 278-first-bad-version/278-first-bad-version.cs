/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
       /* int start=1;
        int end=n+1;
        while(start<end){
            int mid=(start+end)/2;
            if(IsBadVersion(mid)){
                if(mid>1 && IsBadVersion(mid-1))
                    end=mid;
                else return mid;
            }
                
            else
                start=mid+1;
            
            
        }
        return -1;*/
        
         int left=1;
        int right=n;
        int middle=0;
        while(left<right){
            middle=left+(right-left)/2;
            if(IsBadVersion(middle))
                right=middle;
            else
                left=middle+1;
            
        }
        return left;
        
    }
}