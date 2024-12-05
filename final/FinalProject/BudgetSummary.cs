namespace BudgetManager
{
    public class BudgetSummary
    {
        public decimal TotalIncome { get; private set; }
        public decimal TotalExpenses { get; private set; }
        public decimal NetBalance => TotalIncome - TotalExpenses;
        public decimal SavingsGoal { get; private set; }
        public decimal RemainingToSave => SavingsGoal > 0 ? SavingsGoal - NetBalance : 0;

        public BudgetSummary(decimal totalIncome, decimal totalExpenses, decimal savingsGoal)
        {
            TotalIncome = totalIncome;
            TotalExpenses = totalExpenses;
            SavingsGoal = savingsGoal;
        }

        public override string ToString()
        {
            string goalStatus = RemainingToSave > 0
                ? $"You need to save an additional {RemainingToSave:C} to reach your goal."
                : "Congratulations! You've met your savings goal.";

            return $"Total Income: {TotalIncome:C}\n" +
                   $"Total Expenses: {TotalExpenses:C}\n" +
                   $"Net Balance: {NetBalance:C}\n" +
                   $"Savings Goal: {SavingsGoal:C}\n" +
                   $"{goalStatus}";
        }
    }
}
