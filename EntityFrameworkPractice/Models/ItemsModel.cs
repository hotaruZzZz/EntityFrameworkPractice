using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace EntityFrameworkPractice.Models
{
    public partial class ItemsModel : DbContext
    {
        public ItemsModel()
            : base("name=ItemsModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

        }

        public virtual DbSet<ItemTable> ItemTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemTable>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
