using System;

namespace Task3
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Peek();
        void Display();
        bool IsEmpty();
        bool IsFull();
    }
}
