using System;
using System.Collections.Generic;

namespace BudgetManager
{
    public class BudgetManager
    {
        private List<Transaction> Transactions { get; set; }
        private SavingsGoal SavingsGoal { get; set; }

        public BudgetManager()
        {
            Transactions = new List<Transaction>();
            SavingsGoal = new SavingsGoal();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            Console.WriteLine($"{transaction.GetType().Name} added: {transaction.Description} - {transaction.Amount:C}");
        }

        public BudgetSummary GetBudgetSummary()
        {
            decimal totalIncome = 0, totalExpenses = 0;

            foreach (var transaction in Transactions)
            {
                if (transaction is Income) totalIncome += transaction.Amount;
                if (transaction is Expense) totalExpenses += transaction.Amount;
            }

            return new BudgetSummary(totalIncome, totalExpenses, SavingsGoal.GoalAmount);
        }

        public void SetSavingsGoal(decimal goalAmount)
        {
            SavingsGoal.SetGoal(goalAmount);
        }
    }
}
