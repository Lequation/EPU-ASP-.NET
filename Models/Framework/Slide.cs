namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? TypeSlideId { get; set; }

        public bool? IsImageMain { get; set; }

        public int? Location { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        public virtual TypeSlide TypeSlide { get; set; }
    }
}
