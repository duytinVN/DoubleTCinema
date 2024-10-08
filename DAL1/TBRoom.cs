//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBRoom()
        {
            this.TBSeats = new HashSet<TBSeat>();
            this.TBSchedules = new HashSet<TBSchedule>();
        }
    
        public int room_id { get; set; }
        public string room_name { get; set; }
        public int room_number_of_seat { get; set; }
        public int room_number_of_row { get; set; }
        public bool is_deleted { get; set; }
        public Nullable<int> room_type_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSeat> TBSeats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSchedule> TBSchedules { get; set; }
        public virtual TBRoomType TBRoomType { get; set; }
    }
}
