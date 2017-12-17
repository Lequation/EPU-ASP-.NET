namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleFunction")]
    public partial class RoleFunction
    {
        public int Id { get; set; }

        public int? RoleId { get; set; }

        public int? CategoryId { get; set; }

        public int? FunctionParentId { get; set; }

        public int? Location { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        public virtual Category Category { get; set; }

        public virtual Role Role { get; set; }
    }
}
