using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverSDEPratice.LinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Next;
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedListOps
    {
        //Add node
        public void Add(int data, Node<int> head)
        {
            Node<int> node = new Node<int>(data);
            
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<int> curr = head;
                while(curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = node;
            }
        }

        //Display list
        public void display(Node<int> head)
        {
            if (head == null)
                Console.Write("List is empty");
            while(head != null)
            {
                Console.Write(head.Value + "-->");
                head = head.Next;
            }
        }

        //Reverse List
        public Node<int> ReverseList(Node<int> head)
        {
            Node<int> curr = head;
            Node<int> prev = null, next = null;

            while(curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            return prev;

        }
        
    }

}
