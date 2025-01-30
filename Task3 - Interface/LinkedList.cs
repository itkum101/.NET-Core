using System;
using System.Collections.Generic;

namespace Task3
{
    internal sealed class LinkedList<T> : ILinkedList<T>
    {
        private Node<T>? head;

        public LinkedList()
        {
            head = null;
        }

        public void InsertItem(T data)
        {
            var newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var currentNode = head;
                while (currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }
                currentNode.nextNode = newNode;
                
            }
            Console.WriteLine($"Inserted: {data}");
        }

        public void RemoveItem(T data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. Nothing to remove.");
                return;
            }

            if (EqualityComparer<T>.Default.Equals(head.data, data))
            {
                head = head.nextNode;
                Console.WriteLine($"Removed: {data}");
                return;
            }

            
            var currentNode = head;
            Node<T> previousNode = currentNode;

            while (currentNode!= null && !EqualityComparer<T>.Default.Equals(currentNode.data, data))
            {
             
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }

            if(currentNode == null || previousNode == null)
            {
                Console.WriteLine($"No node found with value: {data}");
            }
            else
            {
                previousNode.nextNode = currentNode.nextNode;
            }
            
        }

        // Insert Item After is implementd in DoublyLinkedList so no need to implemnt here the same logic. 

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            Console.Write("Linked List: ");
            var currentNode = head;
            while (currentNode != null)
            {
                Console.Write($"{currentNode.data} -> ");
                currentNode = currentNode.nextNode;
            }
            Console.WriteLine("null");
        }

        public void Clear()
        {
            head = null;
            Console.WriteLine("List cleared.");
        }
    }
}
