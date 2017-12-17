namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            Attactments = new HashSet<Attactment>();
            CategoryNewsMappings = new HashSet<CategoryNewsMapping>();
            Tags = new HashSet<Tag>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewsId { get; set; }

        [StringLength(30)]
        public string NewsCode { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Contents { get; set; }

        public DateTime? DateStartOn { get; set; }

        public DateTime? DateStartActive { get; set; }

        public DateTime? DateEndOn { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? ViewNumber { get; set; }

        public int? LikeNumber { get; set; }

        public int? CommentNumber { get; set; }

        public int? Location { get; set; }

        [StringLength(1000)]
        public string Images { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public bool? IsLogin { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string MetaKeyword { get; set; }

        [StringLength(300)]
        public string MetaDescrption { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attactment> Attactments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryNewsMapping> CategoryNewsMappings { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
