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
    
    public partial class TypeSlide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeSlide()
        {
            this.Slides = new HashSet<Slide>();
        }
    
        public int TypeSlideId { get; set; }
        public string TypeSlideName { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slide> Slides { get; set; }
    }
}