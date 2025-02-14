using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9___Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public (int, int) AddTwoDigit(int num1, int num2, int num3 = 0)
        {
            int sum = num1 + num2 + num3;
            return (sum % 10, sum / 10);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0); 
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int num1 = (l1 != null) ? l1.val : 0;
                int num2 = (l2 != null) ? l2.val : 0;

                var result = AddTwoDigit(num1, num2, carry);
                carry = result.Item2;

                current.next = new ListNode(result.Item1);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummyHead.next; 
        }
    }
}
