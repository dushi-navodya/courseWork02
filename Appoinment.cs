//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseWork02
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appoinment
    {
        public int AppoinmentId { get; set; }
        public Nullable<int> IncomeId { get; set; }
        public Nullable<int> ExpenseId { get; set; }
        public string InviteeName { get; set; }
        public string Location { get; set; }
        public string Purpose { get; set; }
    
        public virtual Expense Expense { get; set; }
        public virtual Income Income { get; set; }
    }
}
