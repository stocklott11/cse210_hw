using System;

namespace BudgetManager
{
    public class SavingsGoal
    {
        public decimal GoalAmount { get; private set; }

        public SavingsGoal()
        {
            GoalAmount = 0;
        }

        public void SetGoal(decimal goalAmount)
        {
            if (goalAmount <= 0)
            {
                throw new ArgumentException("Savings goal must be greater than zero.");
            }

            GoalAmount = goalAmount;
            Console.WriteLine($"Savings goal set to: {GoalAmount:C}");
        }
    }
}
