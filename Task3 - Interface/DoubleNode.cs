using System;

namespace Task3
{
    internal class DoubleNode<T>
    {
        public T data { get; set; }
        public DoubleNode<T>? nextNode { get; set; }
        public DoubleNode<T>? previousNode { get; set; }

        public DoubleNode(T data)
        {
            this.data = data;
            nextNode = null;
            previousNode = null;
        }
    }
}
