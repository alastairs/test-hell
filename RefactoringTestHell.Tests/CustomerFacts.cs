using Xunit;

namespace RefactoringTestHell.Tests
{
    internal class CustomerFacts
    {
        [Fact]
        public void Placing_An_Order_Adds_The_Order_To_The_Customers_Account()
        {
            // Arrange    
            var customer = new Customer(
                1, // Id        
                "Joe", "Bloggs", // Name        
                "10 City Road", "Staines",
                "Middlesex", "AB1 2CD" // Address    
            );

            var order = new Order(1, customer);

            // Act, Assert: not interesting for this example
        }
    }
}
