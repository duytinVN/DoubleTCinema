//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoubleTCinema.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBStaff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBStaff()
        {
            this.TBReceipts = new HashSet<TBReceipt>();
            this.TBShifts = new HashSet<TBShift>();
        }
    
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public string username { get; set; }
        public string pwd { get; set; }
        public string staff_phone { get; set; }
        public string email { get; set; }
        public bool role { get; set; }
        public bool is_deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBReceipt> TBReceipts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBShift> TBShifts { get; set; }
    }
}
