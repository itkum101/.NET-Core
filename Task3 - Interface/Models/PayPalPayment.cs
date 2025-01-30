using System;
using System.Text.RegularExpressions;
using Task3.Interfaces;

namespace Task3.Models
{
    internal class PayPalPayment : IPayment
    {
        public string Email;
        public string transactionID;
        public double Amount;

        public void ProcessPayment()
        { 
            if (string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Invalid email address.");
                return;
            }
            if (Amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return;
            }

            Console.WriteLine($"Processing payment of {Amount} from PayPal account {Email}");

            Console.WriteLine($"Payment successful! Transaction ID: {transactionID}");
        }
    }
}
