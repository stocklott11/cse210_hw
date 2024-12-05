namespace BudgetManager
{
    public abstract class Transaction
    {
        public string Description { get; private set; }
        public decimal Amount { get; private set; }

        protected Transaction(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Description}: {Amount:C}";
        }
    }
}
