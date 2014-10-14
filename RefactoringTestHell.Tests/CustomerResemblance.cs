using System;

namespace RefactoringTestHell.Tests
{
    class CustomerResemblance : Customer, IEquatable<Customer>
    {
        public CustomerResemblance(int id, string givenName, string familyName, string addressLine1, string addressLine2,
            string addressLine3, string postCode)
            : base(id, givenName, familyName, addressLine1, addressLine2, addressLine3, postCode)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        new public bool Equals(Customer other)
        {
            return GivenName == other.GivenName &&
                   FamilyName == other.FamilyName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
