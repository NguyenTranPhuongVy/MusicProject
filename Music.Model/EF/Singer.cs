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
    
    public partial class Singer
    {
        public int singer_id { get; set; }
        public string singer_name { get; set; }
        public Nullable<bool> singer_active { get; set; }
        public Nullable<bool> singer_bin { get; set; }
        public string singer_note { get; set; }
        public string singer_img { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual User User { get; set; }
    }
}