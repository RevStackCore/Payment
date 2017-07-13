

namespace RevStackCore.Payment.Model
{
    public interface IAuthorize : RevStackCore.Pattern.IEntity<string>
    {
        ICustomer Customer { get; set; }
        IShipping Shipping { get; set; }
        ICreditCard CreditCard { get; set; }
        decimal Amount { get; set; }
    }
}
