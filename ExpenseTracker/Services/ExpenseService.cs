using ExpenseTracker.Enums;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private List<Expense> _expenses = new()
        {
           new Expense
           {
               ExpenseId = Guid.NewGuid(),
               Date = DateTime.Now,
               AccountType = PaymentType.Cash,
               Category = ExpenseCategory.Food,
               Amount = 50.00m,
               Title = "Groceries",
               Description = "Weekly grocery shopping"
           },
           new Expense
           {
               ExpenseId = Guid.NewGuid(),
               Date = DateTime.Now,
               AccountType = PaymentType.CreditCard,
               Category = ExpenseCategory.Transportation,
               Amount = 20.00m,
               Title = "Gas",
               Description = "Fuel for the car"
           }
        };
        public void AddExpense(Expense expense)
        {
            if (expense == null)
            {
                throw new ArgumentNullException(nameof(expense));
            }
            expense.ExpenseId = Guid.NewGuid(); // Assign a new GUID for the expense ID
            _expenses.Add(expense);
        }
        public List<Expense> GetExpenses()
        {
            return _expenses;
        }
        public void DeleteExpense(Guid expenseId)
        {
            var expense = _expenses.FirstOrDefault(e => e.ExpenseId == expenseId);
            if (expense != null)
            {
                _expenses.Remove(expense);
            }
        }
        public void UpdateExpense(Expense updatedExpense)
        {
            var expense = _expenses.FirstOrDefault(e => e.ExpenseId == updatedExpense.ExpenseId);
            if (expense != null)
            {
                expense.Date = updatedExpense.Date;
                expense.AccountType = updatedExpense.AccountType;
                expense.Category = updatedExpense.Category;
                expense.Amount = updatedExpense.Amount;
                expense.Title = updatedExpense.Title;
                expense.Description = updatedExpense.Description;
            }
        }
        public Expense GetExpenseById(Guid expenseId)
        {
            return _expenses.FirstOrDefault(e => e.ExpenseId == expenseId);
        }

    }
}
