using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Income
    {
        public Income(IncomeType incomeType, double amount)
        {
            IncomeType = incomeType;
            Amount = amount;
        }
        public IncomeType IncomeType { get; set; }
        public double Amount { get; set; }
    }
}
