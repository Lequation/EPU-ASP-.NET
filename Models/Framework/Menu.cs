namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuId { get; set; }

        public int? CategoryId { get; set; }

        public int? TypeMenuId { get; set; }

        public int? Location { get; set; }

        public int? MenuParentId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UserId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Status { get; set; }

        public virtual Category Category { get; set; }

        public virtual TypeMenu TypeMenu { get; set; }
    }
}
