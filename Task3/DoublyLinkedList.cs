using System;
using System.Collections.Generic;

namespace Task3
{
    internal sealed class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        private DoubleNode<T>? head;
        private DoubleNode<T>? tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertItem(T data)
        {
            var newNode = new DoubleNode<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode; 
            }
            else
            {
                var currentNode = head;
                while (currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }
                newNode.previousNode = currentNode; 
                currentNode.nextNode = newNode;
                tail = newNode; 
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

            var currentNode = head;
            while (currentNode != null && !EqualityComparer<T>.Default.Equals(currentNode.data, data))
            {
                currentNode = currentNode.nextNode;
            }

            if (currentNode == null)
            {
                Console.WriteLine($"No node found with value: {data}");
                return;
            }

            if (currentNode == head) // Removing first node
            {
                head = head.nextNode;
                // Now there may be single node.
                // if there is single item then next node can be null. 
                // head is n
                if (head != null)
                {
                    head.previousNode = null;
                }
                else
                {
                    tail = null;
                }
            }
            else if (currentNode == tail) // Removing last node
            {
                tail = tail.previousNode;
                // Now exact same case as above currentNode = head.
                if(tail!= null)
                {
                    tail.nextNode = null;
                }
                else
                {
                    head = null; 
                }
               
            }
            else // Removing a middle node
            {

                currentNode.previousNode.nextNode = currentNode.nextNode;
                currentNode.nextNode.previousNode = currentNode.previousNode;
            }

            Console.WriteLine($"Removed: {data}");
        }

        public void InsertItemAfter(T targetData, T newData)
        {
            var currentNode = head;

            while (currentNode != null && !EqualityComparer<T>.Default.Equals(currentNode.data, targetData))
            {
                currentNode = currentNode.nextNode;
            }

            if (currentNode == null)
            {
                Console.WriteLine($"No node found with value: {targetData}");
                return;
            }

            var newNode = new DoubleNode<T>(newData);
            newNode.nextNode = currentNode.nextNode; 
            currentNode.nextNode = newNode;
            newNode.previousNode = currentNode;
       

            if (currentNode == tail) // If inserting after the last node
                tail = newNode;

            Console.WriteLine($"Inserted {newData} after {targetData}");
        }

        public void DisplayFromLast()
        {
            var currentNode = tail;
            Console.WriteLine("Displaying list from last:");
            while (currentNode != null)
            {
                Console.Write($"{currentNode.data} ");
                currentNode = currentNode.previousNode;
            }
            Console.WriteLine();
        }

        public void DisplayFromFirst()
        {
            var currentNode = head;
            Console.WriteLine("Displaying list from first:");
            while (currentNode != null)
            {
                Console.Write($"{currentNode.data} ");
                currentNode = currentNode.nextNode;
            }
            Console.WriteLine();
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Console.WriteLine("List cleared.");
        }
    }
}
