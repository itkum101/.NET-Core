using System;

namespace Task3
{
    // Simpler implementation of Stack can be achived using list and linked list. 
    internal sealed class Stack<T> : IStack<T>
    {
        private T[] _items;
        private readonly int _maximumSize;
        private int _currentIndex;

        public Stack(int maximumSize = 100) // Default max size = 100
        {
            _maximumSize = maximumSize;
            _items = new T[_maximumSize];
            _currentIndex = 0;
        }

        public void Push(T data)
        {
            if (_currentIndex >= _maximumSize)
            {
                Console.WriteLine("Stack Overflow.");
                return;
            }

            _items[_currentIndex++] = data;
            Console.WriteLine($"Item Pushed: {data}");
        }

        public T Pop()
        {
            if (_currentIndex == 0)
            {
                throw new InvalidOperationException("Stack empty.");
            }

            T poppedItem = _items[--_currentIndex];
            Console.WriteLine($"Popped: {poppedItem}");
            return poppedItem;
        }

        public T Peek()
        {
            if (_currentIndex == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _items[_currentIndex - 1];
        }

        public void Display()
        {
            if (_currentIndex == 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.Write("Stack ");
            for (int i = _currentIndex - 1; i >= 0; i--)
            {
                Console.Write($"{_items[i]} ");
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return _currentIndex == 0;
        }

        public bool IsFull()
        {

            return _currentIndex == _maximumSize;
        }
    }
}
