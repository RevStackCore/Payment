

namespace RevStackCore.Payment.Model
{
    public interface IVoid : RevStackCore.Pattern.IEntity<string>
    {
        decimal Amount { get; set; }
        //string TransactionId { get; set; }
    }
}
