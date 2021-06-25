using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookManager2506.Models
{
    public partial class BookManagerContext : DbContext
    {
        public BookManagerContext()
            : base("name=BookManagerContext")
        {
        }

        public virtual DbSet<Sach> Saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>()
                .Property(e => e.ImageCover)
                .IsUnicode(false);
        }
    }
}
