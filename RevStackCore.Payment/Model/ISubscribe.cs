using System;

namespace RevStackCore.Payment.Model
{
    public interface ISubscribe : RevStackCore.Pattern.IEntity<string>
    {
        string Name { get; set; }
        string Description { get; set; }
        ICustomer Customer { get; set; }
        IShipping Shipping { get; set; }
        ICreditCard CreditCard { get; set; }
        decimal Amount { get; set; }
        short BillingCycles { get; set; }
        BillingInterval BillingInterval { get; set; }
        short TotalOccurrences { get; set; } 
        DateTime StartsOn { get; set; }
        short TrialOccurrences { get; set; }
        decimal TrialAmount { get; set; }
    }
}
