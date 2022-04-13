using System;
namespace SalesService
{
    public interface IGetPayment
    {
        public Payment GeneratePayment(decimal amount);
    }
}
