using System;
namespace SalesService
{
    public abstract class Payment
    {

        public decimal AmountPayed { get; set; }

        public Payment(decimal amount)
        {
            AmountPayed = amount;
        }
    }
}
