using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
    //Merge two sorted linked lists and return it as a new list.The new list should be made by splicing together the nodes of the first two lists.

        //Approach is to take the first node in one list and have its next value point to the first value in the other list creating a new list as it goes. Need to check which nodes value is higher and have it be pointed to. 

        //l1 = 1-2-4  l2 = 1-3-4 output = 1-1-2-4-4
        //l1 = 1-2-4  l2 = 0-3-3 output = 0-1-2-3-3-4

        /// <summary>
        /// Quick class to set up a singly linked list with only the properties shown.
        /// </summary>
        public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int x) { value = x; }
    }
    public class MergeTwoSortedLL
    {
        public ListNode MergeLists(ListNode l1, ListNode l2)
        {
            ListNode holder = new ListNode();
            while (l1.next != null && l2.next != null)
            {
            }
            
        }
    }
}
