namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Categories = new HashSet<Category>();
            Configs = new HashSet<Config>();
            News = new HashSet<News>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string PasswordHash { get; set; }

        [StringLength(500)]
        public string FullName { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        public bool? EmailConfirmaed { get; set; }

        public int? RoleId { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(10)]
        public string Sex { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public bool? PhoneNumberConfirmed { get; set; }

        public string Avata { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? LoginNewDate { get; set; }

        public bool? LockoutEnabled { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Config> Configs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }

        public virtual Role Role { get; set; }
    }
}
