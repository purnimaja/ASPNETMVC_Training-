//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public int albumid { get; set; }
        public string albumname { get; set; }
        public Nullable<int> genereid { get; set; }
        public Nullable<int> artistid { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Genere Genere { get; set; }
    }
}
