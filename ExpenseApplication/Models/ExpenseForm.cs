﻿using System.Collections.Generic;
using System.Linq;

namespace ExpenseApplication.Models
{
    public enum States
    {
        Submitted,
        Approved,
        Rejected,
        WaitingForReimbursement,
        Reimbursed
    }

    public class ExpenseForm
    {
        public ICollection<Expense> Expenses { get; set; }
        public States State { get; set; }
        private decimal _total;

        public decimal Total
        {
            get => _total;

            // Total of the amounts on each expense, not reimbursement amounts
            set => _total = Expenses.Sum(expense => expense.Amount);
        }
        
        public string RejectReason { get; set; }
    }
}