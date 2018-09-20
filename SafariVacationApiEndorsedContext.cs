using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SafariVacationApiEndorsed
{
    public partial class SafariVacationApiEndorsedContext : DbContext
    {
        public SafariVacationApiEndorsedContext()
        {
        }

        public SafariVacationApiEndorsedContext(DbContextOptions<SafariVacationApiEndorsedContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost; Database=SafariVacationApiEndorsed");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<SeenAnimal> SeenAnimals { get; set; }
    }
}
