namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryNewsMapping")]
    public partial class CategoryNewsMapping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryNewsMappingId { get; set; }

        public int? CategoryId { get; set; }

        public int? NewsId { get; set; }

        public bool? IsFeaturedNews { get; set; }

        public int? Status { get; set; }

        public virtual Category Category { get; set; }

        public virtual News News { get; set; }
    }
}
