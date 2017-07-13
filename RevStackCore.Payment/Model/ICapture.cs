

namespace RevStackCore.Payment.Model
{
    public interface ICapture : RevStackCore.Pattern.IEntity<string>
    {
        decimal Amount { get; set; }
    }
}
