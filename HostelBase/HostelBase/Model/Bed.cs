//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelBase.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bed()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int ID { get; set; }
        public string Sort { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual Room Room { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
