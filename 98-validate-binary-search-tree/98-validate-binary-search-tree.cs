/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
         return isValidBST(root, long.MinValue, long.MaxValue);
    }
    
    public bool isValidBST(TreeNode root, long minVal, long maxVal) {
        if (root == null) return true;
        if (root.val >= maxVal || root.val <= minVal) return false;
        return isValidBST(root.left, minVal, root.val) && isValidBST(root.right, root.val, maxVal);
    }
        /*TreeNode temproot=root;
        if(temproot==null)
            return false;
        if((temproot.left!=null && temproot.left.val>=temproot.val) || (temproot.right!=null && temproot.right.val<=temproot.val)){
            return false;
        }
        IsValidBST(temproot.left);
        IsValidBST(temproot.right);   
        
        return true;
    }*/
}

