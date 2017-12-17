namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EPUDbContext : DbContext
    {
        public EPUDbContext()
            : base("name=EPUDbContext")
        {
        }

        public virtual DbSet<Attactment> Attactments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryNewsMapping> CategoryNewsMappings { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MailServer> MailServers { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleFunction> RoleFunctions { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TypeCategory> TypeCategories { get; set; }
        public virtual DbSet<TypeMenu> TypeMenus { get; set; }
        public virtual DbSet<TypeSlide> TypeSlides { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Config>()
                .Property(e => e.Mobile)
                .IsFixedLength();

            modelBuilder.Entity<Config>()
                .Property(e => e.Hotline)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.PhomeNumber)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.NewsCode)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .HasMany(e => e.Tags)
                .WithRequired(e => e.News)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Sex)
                .IsFixedLength();
        }
    }
}
