namespace DataStructures.LinkedList
{
    /// <summary>
    /// Generic Node class to represent a single node of a Linked List.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
