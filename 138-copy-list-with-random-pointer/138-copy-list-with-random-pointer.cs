/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
         if (head == null) return null;

            var originalToCopyNodeMap = new Dictionary<Node , Node>();
            var p = head;
            while (p != null)
            {
                originalToCopyNodeMap.Add(p, new Node(p.val, null, null));
                p = p.next;
            }

            p = head;
            while (p != null)
            {
                if (p.next != null) originalToCopyNodeMap[p].next = originalToCopyNodeMap[p.next];
                if( p.random != null) originalToCopyNodeMap[p].random = originalToCopyNodeMap[p.random];
                p = p.next;
            }
            return originalToCopyNodeMap[head];
    }
}