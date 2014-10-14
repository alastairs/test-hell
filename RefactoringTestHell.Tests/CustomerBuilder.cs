namespace RefactoringTestHell.Tests
{
    public class CustomerBuilder
    {
        private int id;
        private string givenName;
        private string familyName;
        private string addressLine1;
        private string addressLine2;
        private string addressLine3;
        private string postCode;

        public CustomerBuilder()
        {
            id = 1;
            givenName = "Jane";
            familyName = "Doe";

            // ...
        }

        public CustomerBuilder WithId(int newId)
        {
            id = newId;
            return this;
        }

        public CustomerBuilder WithGivenName(string newGivenName)
        {
            givenName = newGivenName;
            return this;
        }

        public CustomerBuilder WithFamilyName(string newFamilyName)
        {
            familyName = newFamilyName;
            return this;
        }

        // ...

        public Customer Build()
        {
            return new Customer(id, givenName, familyName, addressLine1, addressLine2, addressLine3, postCode);
        }
    }
}
