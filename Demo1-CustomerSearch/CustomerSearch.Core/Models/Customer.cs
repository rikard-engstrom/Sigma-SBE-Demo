namespace CustomerSearch.Core.Models
{
    public class Customer
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }

        public static Customer Create(string givenName, string familyName, string email)
        {
            return new Customer
            {
                GivenName = givenName,
                FamilyName = familyName,
                Email = email
            };
        }
    }
}
