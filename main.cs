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
 /*
 Time: O(n) -- nodes
 Space: O(h) -- height
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) 
    {
        if(root == null) return true;
        return IsMirror(root.left,root.right);    
    }

    public bool IsMirror(TreeNode right, TreeNode left)
    {
        if(right == null && left == null)
        {
            return true;
        }
        else if(right == null || left == null)
        {
            return false;
        }
        else
        {
            return (left.val == right.val && IsMirror(left.left, right.right) && IsMirror(left.right, right.left));
        }
    }
}
