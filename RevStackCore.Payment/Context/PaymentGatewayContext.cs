
namespace RevStackCore.Payment.Context
{
    public abstract class PaymentGatewayContext : IPaymentGatewayContext
    {
        public ServiceMode ServiceMode { get; set; }
    }
}
