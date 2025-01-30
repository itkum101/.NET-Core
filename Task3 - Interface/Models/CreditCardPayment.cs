using System;
using System.Text.RegularExpressions;
using Task3.Interfaces;

namespace Task3.Models
{
    internal class CreditCardPayment : IPayment
    {
        public string cardNumber;
        public string cardHolderName;
        public DateTime expiryDate;
        public double amount;

        public void ProcessPayment()
        {
            // Step 1: Validation
            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("Invalid card number.");
                return;
            }
            if (string.IsNullOrEmpty(cardHolderName))
            {
                Console.WriteLine("Cardholder name is required.");
                return;
            }
            if ( expiryDate <= DateTime.Today)
            {
                Console.WriteLine("Date Expired");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            Console.WriteLine($"Processing payment of {amount:C} using card  {cardNumber}.");

            Console.WriteLine($"Payment successful by {cardHolderName}.");
        }
    }
}
