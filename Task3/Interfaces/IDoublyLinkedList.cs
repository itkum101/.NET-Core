using System;

namespace Task3
{
    public interface IDoublyLinkedList<T>
    {
        void InsertItem(T data);
        void RemoveItem(T data);
        void InsertItemAfter(T targetData, T newData);
        void DisplayFromFirst();
        void DisplayFromLast();
        void Clear();
    }
}
