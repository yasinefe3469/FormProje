//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.OgrenciDers = new HashSet<OgrenciDers>();
        }
    
        public int OgrenciID { get; set; }
        public string OgrenciAdiSoyadi { get; set; }
        public Nullable<int> OgrenciNo { get; set; }
        public System.DateTime OgrenciDogumTarihi { get; set; }
        public System.DateTime OgrenciKayitTarihi { get; set; }
        public string OgrenciBolumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}