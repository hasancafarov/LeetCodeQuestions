/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    ListNode d1 = headA;
    ListNode d2 = headB;
    
    while(d1 != d2) {
        d1 = d1 == null? headB:d1.next;
        d2 = d2 == null? headA:d2.next;
    }
    
    return d1;
    }
}