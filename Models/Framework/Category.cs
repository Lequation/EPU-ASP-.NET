namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            CategoryNewsMappings = new HashSet<CategoryNewsMapping>();
            Menus = new HashSet<Menu>();
            RoleFunctions = new HashSet<RoleFunction>();
        }

        public int Id { get; set; }

        public int CategoryOldId { get; set; }

        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int CategoryParentId { get; set; }

        public int? Location { get; set; }

        public int? IsHome { get; set; }

        public string Images { get; set; }

        public string Url { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string MetaKeyword { get; set; }

        [StringLength(300)]
        public string MetaDescrption { get; set; }

        public int? TypeCategoryId { get; set; }

        public int? LanguageId { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryNewsMapping> CategoryNewsMappings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleFunction> RoleFunctions { get; set; }
    }
}
