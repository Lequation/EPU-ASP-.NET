namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [StringLength(15)]
        public string TagId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public int? TagSize { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }
    }
}
