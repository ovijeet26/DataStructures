using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int length;
        public SinglyLinkedList(T data)
        {
            head = new Node<T>(data);
            tail = head;
            length = 1;
        }
        /// <summary>
        /// Append an element to the last of the list.
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            tail.Next = newNode;
            //Make tail the last element.
            tail = tail.Next;
            length++;
        }
        /// <summary>
        /// Prepend an element to the beginning of the list.
        /// </summary>
        /// <param name="data"></param>
        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            //Make head the first element.
            head = newNode;
            length++;
        }
        /// <summary>
        /// Insert a node at a particular index of the Linkedlist.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        public void Insert(T data, int index)
        {
            if (index < 0)
                throw new Exception("The given index is negative. I mean, are you serious? Gosh!");
            else if (index > length)
                throw new Exception("The given index does not exist. Alas, the list is too short, like life.");
            //If the element to be inserted is the last element, we simply Append it.
            else if (index == length)
            {
                Append(data);
                return;
            }
            Node<T> pointer = TraverseToAnIndex(index - 1);
            Node<T> newNode = new Node<T>(data);
            newNode.Next = pointer.Next;
            pointer.Next = newNode;
            length++;
        }
        /// <summary>
        /// Remove a node at the particular index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAtIndex(int index)
        {
            if (index < 0)
                throw new Exception("The given index is negative. I mean, are you serious? Gosh!");
            else if (index >= length)
                throw new Exception("The given index does not exist. Alas, the list is too short, like life.");
            else if (index == 0)
            {
                head = head.Next;
            }
            else
            {

                //Traversing to the node before the node that is to be deleted.
                Node<T> pointer = TraverseToAnIndex(index - 1);
                pointer.Next = (pointer.Next).Next;
            }
            length--;

        }
        /// <summary>
        /// Reverse a Linked List
        /// </summary>
        public void Reverse()
        {
            if (head.Next == null)
                return;
            tail = head;
            Node<T> current = head;
            Node<T> prev = null;
            Node<T> next = head;
            while (next != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        /// <summary>
        /// Print the Linked List.
        /// </summary>
        public void Print()
        {
            Console.WriteLine();
            Node<T> pointer = head;
            while (pointer != null)
            {
                Console.Write(pointer.Data + " -> ");
                pointer = pointer.Next;
            }
            Console.Write("NULL");
        }

        #region Helper methods
        /// <summary>
        /// Traverse to the last element of the LinkedList.
        /// </summary>
        /// <returns></returns>
        private Node<T> TraverseTillLastElement()
        {
            Node<T> pointer = head;
            //Traverse to the last element
            while (pointer.Next != null)
            {
                pointer = pointer.Next;
            }
            return pointer;
        }
        /// <summary>
        /// Traverse to a particular index of the LinkedList.
        /// </summary>
        /// <returns></returns>
        private Node<T> TraverseToAnIndex(int index)
        {
            if (index >= length)
                throw new Exception("The given index does not exist. Alas, the list is too short, like life.");
            Node<T> pointer = head;
            //Traverse to the given element
            for (int i = 0; i < index; i++)
            {
                pointer = pointer.Next;
            }
            return pointer;
        }
        #endregion
    }
}
