//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tblurunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tblurunler()
        {
            this.TblSatislar = new HashSet<TblSatislar>();
        }
    
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<short> UrunKategori { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string MARKA { get; set; }
        public Nullable<byte> STOK { get; set; }
    
        public virtual TblKategoriler TblKategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSatislar> TblSatislar { get; set; }
    }
}
