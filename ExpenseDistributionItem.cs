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

        public ExpenseDistributionItem(int percentage, ExpenseType expenseType, User user)
        {
            Percentage = percentage;
            ExpenseType = expenseType;
            User = user;
        }
        public int Percentage { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public User User { get; set; }

    }
}
