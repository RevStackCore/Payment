

namespace RevStackCore.Payment.Model
{
    public interface ICustomer : RevStackCore.Pattern.IEntity<string>
    {
        //string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string StateOrProvince { get; set; }
        string Zipcode { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
