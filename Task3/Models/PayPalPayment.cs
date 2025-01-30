using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Console.WriteLine($"Payment Successfull from Email {Email} with Amount{Amount}. Transaction ID is {transactionID}");

        }

    }
}
