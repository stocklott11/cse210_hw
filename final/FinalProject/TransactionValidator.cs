using System;

namespace BudgetManager
{
    public static class TransactionValidator
    {
        public static void ValidatePositiveAmount(decimal amount, string transactionType)
        {
            if (amount <= 0)
            {
                throw new ArgumentException($"{transactionType} amount must be greater than zero.");
            }
        }
    }
}
