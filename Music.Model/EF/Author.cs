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
    
    public partial class Author
    {
        public int author_id { get; set; }
        public string author_name { get; set; }
        public Nullable<bool> author_active { get; set; }
        public Nullable<bool> author_bin { get; set; }
        public string author_note { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<bool> author_option { get; set; }
        public Nullable<System.DateTime> author_datecreate { get; set; }
        public Nullable<System.DateTime> author_dateupdate { get; set; }
        public string author_img { get; set; }
    
        public virtual User User { get; set; }
    }
}
