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
    
    public partial class Love
    {
        public int love_id { get; set; }
        public Nullable<bool> love_active { get; set; }
        public Nullable<bool> love_option { get; set; }
        public Nullable<bool> love_bin { get; set; }
        public Nullable<System.DateTime> love_datecreate { get; set; }
        public Nullable<System.DateTime> love_dateupdate { get; set; }
        public Nullable<int> music_id { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual MusicsList MusicsList { get; set; }
        public virtual User User { get; set; }
    }
}
