using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    
    public class ExpenseDistributionItem
    {
        private double percentage;
        private ExpenseType expenseType;

        public ExpenseDistributionItem(int percentage, Expense expense)
        {
            Percentage = percentage;
            Expense = expense;
        }
        public int Percentage { get; set; }
        public Expense Expense { get; set; }

    }
}
