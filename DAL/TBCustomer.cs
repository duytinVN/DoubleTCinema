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
    
    public partial class TBCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBCustomer()
        {
            this.TBReceipts = new HashSet<TBReceipt>();
        }
    
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public System.DateTime customer_birthday { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set; }
        public Nullable<int> customer_points { get; set; }
        public bool is_deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBReceipt> TBReceipts { get; set; }
    }
}
