using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class IncomeType
    {
        public IncomeType()
        {
        }
        public IncomeType(string name)
        {
            this.Name = name;

        }

        public string Name { get; set; }
    }
}
