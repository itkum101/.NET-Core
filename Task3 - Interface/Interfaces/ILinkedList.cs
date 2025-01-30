using System;

namespace Task3
{
    public interface ILinkedList<T>
    {
        void InsertItem(T data);
        void RemoveItem(T data);
        void Display();
        void Clear();
    }
}
