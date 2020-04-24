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
    
    public partial class Expense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expense()
        {
            this.Appoinments = new HashSet<Appoinment>();
        }
    
        public int UserID { get; set; }
        public int CategoryId { get; set; }
        public int ExpensseId { get; set; }
        public string Description { get; set; }
        public string PayerName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Proffesion { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<byte> IsRecurringEvent { get; set; }
        public Nullable<byte> IsBeginingMonth { get; set; }
        public Nullable<byte> IsEndMonth { get; set; }
        public Nullable<byte> IsSpecDate { get; set; }
        public Nullable<System.DateTime> SpecDate { get; set; }
        public Nullable<byte> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appoinment> Appoinments { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        public virtual User User { get; set; }
    }
}
