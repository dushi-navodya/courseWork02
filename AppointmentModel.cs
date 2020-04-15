using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork02
{
    public class AppointmentModel
    {
        public string InviteeName { get; set; }
        public string Location { get; set; }
        public string Purpose { get; set; }
        public ExpenseModel Expense { get; set; }
    }
}
