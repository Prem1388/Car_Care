using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Car_Care.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Register>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Register>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
