using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_1_c
{
    
    class FluentContext : DbContext
    {
        public FluentContext()
            : base("EF_lesson_6_1_c")
        { }

        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().ToTable("Mobiles");
            modelBuilder.Entity<Phone>().HasKey(p => p.Ident);
            modelBuilder.Entity<Phone>().Ignore(p => p.Discount);
            base.OnModelCreating(modelBuilder);
        }
    }
}
