

namespace RevStackCore.Payment.Model
{
    public interface ICharge : RevStackCore.Pattern.IEntity<string>
    {
        ICustomer Customer { get; set; }
        IShipping Shipping { get; set; }
        ICreditCard CreditCard { get; set; }
        decimal Amount { get; set; }
    }
}
