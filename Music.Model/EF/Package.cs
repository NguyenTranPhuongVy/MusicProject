//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music.Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            this.Pays = new HashSet<Pay>();
        }
    
        public int package_id { get; set; }
        public string package_name { get; set; }
        public Nullable<decimal> package_money { get; set; }
        public string package_content { get; set; }
        public Nullable<System.DateTime> package_datecreate { get; set; }
        public Nullable<bool> package_active { get; set; }
        public Nullable<bool> package_pin { get; set; }
        public Nullable<int> pakage_price { get; set; }
        public Nullable<System.DateTime> pakege_deadline { get; set; }
        public Nullable<bool> package_option { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pay> Pays { get; set; }
    }
}
