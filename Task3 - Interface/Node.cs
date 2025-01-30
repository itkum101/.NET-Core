using System;

namespace Task3
{
    internal class Node<T>
    {
        public T data { get; set; }
        public Node<T>? nextNode { get; set; }

        public Node(T data)
        {
            this.data = data;
            nextNode = null;
        }
    }
}
