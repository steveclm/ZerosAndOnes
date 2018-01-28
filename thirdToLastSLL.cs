using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Steve Clements 1/13/2018. Find the 3rd to last element in a singly linked list
namespace thirdToLastSinglyLinkedList
{
    public class thirdToLastSLL
    {
        public static void Main(String[] args)
        {          
                thirdToLastSLL linkedList = new thirdToLastSLL();

                //inserts new node at the front of the linked list as the method implies
                linkedList.insertAtFront(14);
                linkedList.insertAtFront(32);
                linkedList.insertAtFront(7);
                linkedList.insertAtFront(43);
                linkedList.insertAtFront(15);
                linkedList.insertAtFront(61);
                linkedList.insertAtFront(2);
                linkedList.insertAtFront(99);

                linkedList.thirdFromLast(3);
                Console.ReadLine();
        }

        //inserts node in the front
        public void insertAtFront(int nodeValue)
        {
            //create new node & give it a value
            SLLNode node = new SLLNode(nodeValue);

            //make next the head
            node.next = head;

            //make the head point to the new node
            head = node;
        }

        //node class
        SLLNode head;
        public class SLLNode
        {
            public int data;
            public SLLNode next;
            public SLLNode(int d)
            {
                data = d;
                next = null;
            }
        }

        //method that calculates the 3rd node from the end - in this example, answer should be 7..and is!
        public void thirdFromLast(int n)
        {
            SLLNode pointerOne = head;
            SLLNode pointerTwo = head;

            int count = 0;
            if (head != null)
            {
                while (count < n)
                {
                    if (pointerTwo == null)
                    {                       
                        Console.WriteLine("There are less than " + n + " nodes in this linked list");
                        return;
                    }
                    pointerTwo = pointerTwo.next;
                    count++;
                }
                while (pointerTwo != null)
                {
                    pointerOne = pointerOne.next;
                    pointerTwo = pointerTwo.next;
                }               
            }
            Console.WriteLine("The 3rd to last element of a singly linked list is: " + pointerOne.data);
        }      
    }
}
