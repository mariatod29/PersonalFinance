using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public static class IncomeTypeMenu
    {
        public static IncomeType MainMenu()
        {
            IncomeType activeIncome = new IncomeType("Active income");
            activeIncome.ToString().ToLower();
            IncomeType portfolioIncome = new IncomeType("Portfolio income");
            portfolioIncome.ToString().ToLower();
            IncomeType passiveIncome = new IncomeType("Passive income");
            passiveIncome.ToString().ToLower();

            Console.WriteLine();
            Console.WriteLine("1 - Active income");
            Console.WriteLine("2 - Portfolio income");
            Console.WriteLine("3 - Passive income");
            Console.Write("\r\nSelect 1, 2 or 3: ");

            switch (Console.ReadLine())
            {
                case "2":
                    return portfolioIncome;
                case "3":
                    return passiveIncome;
                default:
                case "1":
                    return activeIncome;
            }
        }

    }
}
