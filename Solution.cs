/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // Null safety check
        if (head == null) return false;
        
        // Create two pointers
        var slow = head;
        var fast = head.next;
        
        while (slow != fast) { // Once the slower pointer equals fast pointer we've identified a cycle
            
            // End of list reached, no cycle
            if (fast == null || fast.next == null) {
                return false;
            }
            
            // Increment slow one point, fast two points, in the list
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // If we've broken out of the list the cycle has been found
        return true;
    }
}
