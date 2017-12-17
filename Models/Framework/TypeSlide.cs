namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeSlide")]
    public partial class TypeSlide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeSlide()
        {
            Slides = new HashSet<Slide>();
        }

        public int TypeSlideId { get; set; }

        [StringLength(500)]
        public string TypeSlideName { get; set; }

        public int? Status { get; set; }

        public int? DepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slide> Slides { get; set; }
    }
}
