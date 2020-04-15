using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork02
{
    public class ExpenseModel : Model
    {
        public string PayeeName { get; set; }
        public ExpenseCategoryModel ExpenseCategory { get; set; }
    }
}
