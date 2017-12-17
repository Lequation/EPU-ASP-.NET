namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attactment")]
    public partial class Attactment
    {
        public int AttactmentId { get; set; }

        [StringLength(500)]
        public string AttactmentName { get; set; }

        public string AttactmentLink { get; set; }

        public int? NewsId { get; set; }

        public int? Status { get; set; }

        public virtual News News { get; set; }
    }
}
