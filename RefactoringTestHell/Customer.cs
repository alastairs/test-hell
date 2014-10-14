using System;

namespace RefactoringTestHell
{
    public class Customer : IEquatable<Customer>
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

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return Equals(this, other);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public int Id { get; private set; }
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string AddressLine3 { get; private set; }
        public string PostCode { get; private set; }

        private static bool Equals(Customer a, Customer b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            return a.Id == b.Id;
        }
    }
}
