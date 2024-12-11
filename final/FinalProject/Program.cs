using System;

namespace BudgetManager
{
    class Program
    {
        private static BudgetManager _budgetManager = new BudgetManager();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Manager!");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Set a Savings Goal");
                Console.WriteLine("2. Add an Expense");
                Console.WriteLine("3. Add Income");
                Console.WriteLine("4. View Your Budget Summary");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            SetSavingsGoal();
                            break;
                        case "2":
                            AddExpense();
                            break;
                        case "3":
                            AddIncome();
                            break;
                        case "4":
                            ViewSummary();
                            break;
                        case "5":
                            Console.WriteLine("Thank you for using the Budget Manager. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static void AddIncome()
        {
            Console.Write("Enter income description: ");
            string description = Console.ReadLine();
            Console.Write("Enter income amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            _budgetManager.AddTransaction(new Income(description, amount));
        }

        private static void AddExpense()
        {
            Console.Write("Enter expense description: ");
            string description = Console.ReadLine();
            Console.Write("Enter expense amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            _budgetManager.AddTransaction(new Expense(description, amount));
        }

        private static void ViewSummary()
        {
            var summary = _budgetManager.GetBudgetSummary();
            Console.WriteLine("\n--- Budget Summary ---");
            Console.WriteLine(summary.ToString());
        }

        private static void SetSavingsGoal()
        {
            Console.Write("Enter your savings goal: ");
            decimal goalAmount = decimal.Parse(Console.ReadLine());
            _budgetManager.SetSavingsGoal(goalAmount);
        }
    }
}
