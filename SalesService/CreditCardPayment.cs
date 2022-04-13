using System;
namespace SalesService
{
    public class CreditCardPayment : Payment
    {        
        public string CreditCard { get; set; }

        public CreditCardPayment()
        {
        }
    }
}
