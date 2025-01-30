using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Task3.Interfaces;

namespace Task3.Models
{
    internal class CreditCardPayment : IPayment
    {
        public string cardNumber;
        public string cardHolderName;
        public DateTime? expiryDate;
        public double amount;


        public void ProcessPayment()
        {
            Console.WriteLine($"Payment Successfull from CardNumber {cardNumber} with Amount{amount}. Transaction Initator is {cardHolderName}");
        }
    }
}
