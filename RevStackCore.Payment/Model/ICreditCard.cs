

namespace RevStackCore.Payment.Model
{
    public interface ICreditCard : RevStackCore.Pattern.IEntity<string>
    {
        string CardNumber { get; set; }
        string ExpirationMonth { get; set; }
        string ExpirationYear { get; set; }
        string CVV { get; set; }
    }
}
