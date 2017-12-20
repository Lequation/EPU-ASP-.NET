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
    
    public partial class News
    {
        public News()
        {
            this.Attactments = new HashSet<Attactment>();
            this.CategoryNewsMappings = new HashSet<CategoryNewsMapping>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int NewsId { get; set; }
        public string NewsCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public Nullable<System.DateTime> DateStartOn { get; set; }
        public Nullable<System.DateTime> DateStartActive { get; set; }
        public Nullable<System.DateTime> DateEndOn { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> ViewNumber { get; set; }
        public Nullable<int> LikeNumber { get; set; }
        public Nullable<int> CommentNumber { get; set; }
        public Nullable<int> Location { get; set; }
        public string Images { get; set; }
        public string Url { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescrption { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<Attactment> Attactments { get; set; }
        public virtual ICollection<CategoryNewsMapping> CategoryNewsMappings { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}