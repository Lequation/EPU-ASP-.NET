//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPUWeb.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoryNewsMapping
    {
        public int CategoryNewsMappingId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> NewsId { get; set; }
        public Nullable<bool> IsFeaturedNews { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual News News { get; set; }
    }
}
