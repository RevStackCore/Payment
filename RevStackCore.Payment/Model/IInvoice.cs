

namespace RevStackCore.Payment.Model
{
    public interface IInvoice : RevStackCore.Pattern.IEntity<string>
    {
        string InvoiceNumber { get; set; }
    }
}
