
namespace RevStackCore.Payment.Model
{
    public interface ITransactions : RevStackCore.Pattern.IEntity<string>
    {
        string BatchId { get; set; }
    }
}
