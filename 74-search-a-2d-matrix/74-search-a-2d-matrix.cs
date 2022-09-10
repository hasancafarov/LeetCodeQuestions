public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int lo = 0;
        if(matrix.Length == 0) return false;
        int n = matrix.Length; 
        int m = matrix[0].Length; 
        int hi = (n * m) - 1;
        
        while(lo <= hi) {
            int mid = (lo + (hi - lo) / 2);
            if(matrix[mid/m][mid % m] == target) {
                return true;
            }
            if(matrix[mid/m][mid % m] < target) {
                lo = mid + 1;
            }
            else {
                hi = mid - 1;
            }
        }
        return false;
    }
}