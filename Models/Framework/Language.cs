namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        public int LanguageId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        [StringLength(500)]
        public string Flag { get; set; }

        public int? Status { get; set; }
    }
}
