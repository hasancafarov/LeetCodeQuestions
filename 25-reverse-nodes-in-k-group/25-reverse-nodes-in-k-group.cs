/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    static int lengthOfLinkedList(ListNode head) {
    int length = 0;
    while(head != null) {
        ++length;
        head = head.next;
    }
    return length;
}

    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null||head.next == null) return head;
    
    int length = lengthOfLinkedList(head);
    
    ListNode dummyHead = new ListNode(0);
    dummyHead.next = head;
    
    ListNode pre = dummyHead;
    ListNode cur;
    ListNode nex;
    
    while(length >= k) {
        cur = pre.next;
        nex = cur.next;
        for(int i=1;i<k;i++) {
            cur.next = nex.next;
            nex.next = pre.next;
            pre.next = nex;
            nex = cur.next;
        }
        pre = cur;
        length -= k;
    }
    return dummyHead.next;
    }
}