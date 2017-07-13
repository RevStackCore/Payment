

namespace RevStackCore.Payment.Model
{
    public interface ICredit : RevStackCore.Pattern.IEntity<string>
    {
        decimal Amount { get; set; }
    }
}
