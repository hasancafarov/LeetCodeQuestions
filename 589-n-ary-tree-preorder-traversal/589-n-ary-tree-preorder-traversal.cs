/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        List<int> list = new List<int>();
        if (root == null) return list;
        
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        
        while (stack.Count!=0) {
            root = stack.Pop();
            list.Add(root.val);
            for (int i = root.children.Count- 1; i >= 0; i--)
                stack.Push(root.children[i]);
        }
        
        return list;
    }
}