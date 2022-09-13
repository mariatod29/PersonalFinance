using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Domain
{
    public static class ExpenseTypeMenu
    {
        public static ExpenseType MainMenu()
        {
            ExpenseType needs = new ExpenseType("Needs");
            needs.ToString().ToLower();
            ExpenseType wants = new ExpenseType("Wants");
            wants.ToString().ToLower();
            ExpenseType savings = new ExpenseType("Savings");
            savings.ToString().ToLower();

            Console.WriteLine();
            Console.WriteLine("1 - Needs");
            Console.WriteLine("2 - Wants");
            Console.WriteLine("3 - Savings");
            Console.Write("\r\nSelect 1, 2 or 3: ");

            switch (Console.ReadLine())
            {  
                case "2":
                    return wants;
                case "3":
                    return savings;
                case "1":
                default:
                    return needs;

            }
        }
        
}
}
