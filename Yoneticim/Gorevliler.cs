//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yoneticim
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gorevliler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gorevliler()
        {
            this.Kalemlers = new HashSet<Kalemler>();
        }
    
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string IsTanimi { get; set; }
        public Nullable<decimal> Maasi { get; set; }
        public string TcNo { get; set; }
        public string SigortaNo { get; set; }
        public int MulkId { get; set; }
        public int GorevliTurId { get; set; }
    
        public virtual GorevliTurleri GorevliTurleri { get; set; }
        public virtual Mulkler Mulkler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kalemler> Kalemlers { get; set; }
    }
}
