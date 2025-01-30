using System;
using Task3.Interfaces;
using Task3.Models;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            IPayment paypalPayment = new PayPalPayment
            {
                Email = "subedimukti14@gmail.com",
                transactionID = "123456",
                Amount = 200
            };

            paypalPayment.ProcessPayment(); 

            IPayment creditCardPayment = new CreditCardPayment
            {
                cardNumber = "1111111111111111",
                cardHolderName = "Mukti Subedi",
                expiryDate = new DateTime(2029, 1, 1),
                amount = 100
            };

            creditCardPayment.ProcessPayment(); 



            // === Testing Singly Linked List ===
            Console.WriteLine("SinglyLinkedList");
            LinkedList<int> singlyLinkedList = new LinkedList<int>();


            singlyLinkedList.Display();
            singlyLinkedList.RemoveItem(10);

            singlyLinkedList.InsertItem(10);
            singlyLinkedList.InsertItem(20);
            singlyLinkedList.InsertItem(30);
            singlyLinkedList.Display();

            singlyLinkedList.RemoveItem(20);
            singlyLinkedList.Display();

            singlyLinkedList.RemoveItem(100);
            singlyLinkedList.InsertItem(200);
            singlyLinkedList.InsertItem(300);
            singlyLinkedList.RemoveItem(200);
            singlyLinkedList.Display();
            singlyLinkedList.Clear();
            singlyLinkedList.Display();


            // === Testing Doubly Linked List ===
            Console.WriteLine("\nDoubly Linked List Test");
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.RemoveItem(3);
            doublyLinkedList.InsertItem(1);
            doublyLinkedList.InsertItem(2);
            doublyLinkedList.InsertItem(3);
            doublyLinkedList.DisplayFromFirst(); 
            doublyLinkedList.DisplayFromLast(); 

            doublyLinkedList.RemoveItem(2);
            doublyLinkedList.RemoveItem(5);
            doublyLinkedList.InsertItemAfter(3, 4);
            doublyLinkedList.RemoveItem(4);
            doublyLinkedList.DisplayFromFirst(); 

            doublyLinkedList.RemoveItem(10); // It is not at list
            doublyLinkedList.Clear();
            doublyLinkedList.DisplayFromFirst();



            Console.WriteLine("\n Stack Test ");
            Stack<int> stack = new Stack<int>(5);
            try
            {
                stack.Push(100);
                stack.Push(200);
                stack.Push(300);
                stack.Display();

                Console.WriteLine($"Peek: {stack.Peek()}");

                stack.Pop();
                stack.Display();

                stack.Pop();
                stack.Pop();
                stack.Pop(); //Empty Stack

                //Stack Overflow
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Push(6); //Stack Overflow

                stack.Display();
            }
            catch(Exception Ex)
            {
                Console.WriteLine($"{Ex.Message}");
            }


        }
    }
}

