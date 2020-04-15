using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork02
{
    public class Model
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsRecurringEvent { get; set; }
        public bool IsBeginingMonth { get; set; }
        public bool IsEndMonth { get; set; }
        public bool IsSpecDate { get; set; }
        public DateTime SpecDate { get; set; }
    }
}
