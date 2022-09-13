using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseDistribution
    {
        public string ExpenseDistributionName { get; set; }
        private List<ExpenseDistributionItem> expenseDistributionItems { get; set; }

        public void AddExpenseTypes(ExpenseDistributionItem item)
        {
            expenseDistributionItems.Add(item);
        }

        public void RemoveExpenseTypes()
        {
            expenseDistributionItems.Clear();
        }

        public bool CheckPercentage(ExpenseDistributionItem expenseItem, Income income)
        {
            var result = expenseItem.Expense.Amount * income.Amount / 100;
            return result > expenseItem.Percentage;
        }
    }
}
