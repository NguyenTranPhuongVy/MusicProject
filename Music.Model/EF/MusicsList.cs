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
    
    public partial class MusicsList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusicsList()
        {
            this.Comments = new HashSet<Comment>();
            this.Loves = new HashSet<Love>();
            this.Videos = new HashSet<Video>();
        }
    
        public int music_id { get; set; }
        public string music_name { get; set; }
        public string music_img { get; set; }
        public string music_lyric { get; set; }
        public string music_time { get; set; }
        public Nullable<int> music_view { get; set; }
        public Nullable<int> music_dowload { get; set; }
        public Nullable<int> music_love { get; set; }
        public Nullable<int> user_id { get; set; }
        public string music_linkdow { get; set; }
        public Nullable<System.DateTime> music_datecreate { get; set; }
        public Nullable<System.DateTime> music_dateedit { get; set; }
        public Nullable<bool> music_active { get; set; }
        public Nullable<bool> music_bin { get; set; }
        public Nullable<bool> music_option { get; set; }
        public Nullable<int> nation_id { get; set; }
    
        public virtual User User { get; set; }
        public virtual National National { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Love> Loves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Videos { get; set; }
    }
}
