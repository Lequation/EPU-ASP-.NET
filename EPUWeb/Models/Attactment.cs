//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPUWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attactment
    {
        public int AttactmentId { get; set; }
        public string AttactmentName { get; set; }
        public string AttactmentLink { get; set; }
        public Nullable<int> NewsId { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual News News { get; set; }
    }
}