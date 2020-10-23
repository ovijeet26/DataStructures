using DataStructures.LinkedList;
using System;

namespace DataStructures
{
    class Executor
    {
        static void Main(string[] args)
        {
            //LinkedListAppend();
            //LinkedListPrepend();
            LinkedListInsert();

            Console.ReadKey();
        }
        static void LinkedListAppend()
        {
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>(0);
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Append(6);
            linkedList.Print();
            
        }
        static void LinkedListPrepend()
        {
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>(0);
            linkedList.Prepend(1);
            linkedList.Prepend(2);
            linkedList.Prepend(3);
            linkedList.Prepend(4);
            linkedList.Prepend(5);
            linkedList.Prepend(6);
            linkedList.Print();

        }
        static void LinkedListInsert()
        {
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>(0);
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Append(6);
            linkedList.Print();

            linkedList.Insert(65656,4);
            linkedList.RemoveAtIndex(4);
            linkedList.RemoveAtIndex(0);

            linkedList.Print();

            linkedList.Reverse();
            linkedList.Print();
        }
    }
}
