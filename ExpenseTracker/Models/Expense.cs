using ExpenseTracker.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public Guid ExpenseId { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Account type is required.")]
        public PaymentType AccountType { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public ExpenseCategory Category { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }
    }
}
