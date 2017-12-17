namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(200)]
        public string DepartmentName { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(15)]
        public string PhomeNumber { get; set; }

        public string Photo { get; set; }

        public string Address { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Note { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }
    }
}
