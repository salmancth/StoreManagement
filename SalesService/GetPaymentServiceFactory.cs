using System;
namespace SalesService
{
    public class GetPaymentServiceFactory
    {
        public static IGetPayment GeneratePaymentService()
        {
            return new GetPaymentService();  
        }
    }
}
