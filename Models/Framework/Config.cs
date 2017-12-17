namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config")]
    public partial class Config
    {
        public int ConfigId { get; set; }

        public string Logo { get; set; }

        public string GoogleAnanyticsId { get; set; }

        public string FacebookId { get; set; }

        public string GooglePlusId { get; set; }

        public string TwiterId { get; set; }

        public string YoutubeId { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Hotline { get; set; }

        [StringLength(200)]
        public string SeoTitle { get; set; }

        [StringLength(200)]
        public string SeoKeywords { get; set; }

        [StringLength(300)]
        public string SeoDescription { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
