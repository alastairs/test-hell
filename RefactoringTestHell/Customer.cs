namespace RefactoringTestHell
{
    public class Customer
    {
        public Customer(int id, string givenName, string familyName, string addressLine1, string addressLine2,
                        string addressLine3, string postCode)
        {
            Id = id;
            GivenName = givenName;
            FamilyName = familyName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            PostCode = postCode;
        }

        public int Id { get; private set; }
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string AddressLine3 { get; private set; }
        public string PostCode { get; private set; }
    }
}
