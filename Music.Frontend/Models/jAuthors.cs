using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Music.Frontend.Models
{
    public class jAuthors
    {
        public int author_id { get; set; }
        public string author_name { get; set; }
        public Nullable<bool> author_active { get; set; }
        public Nullable<bool> author_bin { get; set; }
        public string author_note { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<bool> author_option { get; set; }
        public string author_datecreate { get; set; }
        public string author_dateupdate { get; set; }
        public string author_img { get; set; }
    }
}