namespace BudgetManager
{
    public class Expense : Transaction
    {
        public Expense(string description, decimal amount) : base(description, -Math.Abs(amount))
        {
            TransactionValidator.ValidatePositiveAmount(amount, "Expense");
        }
    }
}
