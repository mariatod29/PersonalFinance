using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class User
    {
        private string _name;
        private string _password;
        public string Name 
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name should not be empty");
                }
                _name = value;
            }
        }
        public string Password 
        { 
            get { return _password; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Password should not be empty");
                }
                Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                validateGuidRegex.IsMatch(value);
                _password = value;
            } 
        }
        public List<Expense> Expenses { get { return Expenses; } set { } }
        public List<ExpenseType> ExpenseTypes { get { return ExpenseTypes; } set { } }
        public List<Income> Incomes { get { return Incomes; } set { } }
        public IncomeType IncomeType { get { return IncomeType; } set { } }

       
    }
}
