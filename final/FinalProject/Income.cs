namespace BudgetManager
{
    public class Income : Transaction
    {
        public Income(string description, decimal amount) : base(description, amount)
        {
            TransactionValidator.ValidatePositiveAmount(amount, "Income");
        }
    }
}
