
namespace RefactoringTestHell.Tests
{
    class OrderBuilder
    {
        private int id;
        private Customer customer;

        public OrderBuilder()
        {
            id = 1;
            customer = new CustomerBuilder().Build();
        }

        public OrderBuilder WithId(int newId)
        {
            id = newId;
            return this;
        }

        public OrderBuilder PlacedBy(Customer newCustomer)
        {
            customer = newCustomer;
            return this;
        }

        public Order Build()
        {
            return new Order(id, customer);
        }
    }
}
