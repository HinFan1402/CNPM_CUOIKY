//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYSACH
{
    using System;
    using System.Collections.Generic;
    
    public partial class tDAILY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDAILY()
        {
            this.tHOADONs = new HashSet<tHOADON>();
        }
    
        public int MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string TenChuDaiLy { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> SoDienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tHOADON> tHOADONs { get; set; }
    }
}
