namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeCategory")]
    public partial class TypeCategory
    {
        public int TypeCategoryId { get; set; }

        [StringLength(500)]
        public string TypeCategoryName { get; set; }

        public int? DepartmentId { get; set; }

        public int? Status { get; set; }
    }
}
