using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Data
{
    public class BookContext:DbContext
    {
        public BookContext()
        {

        }

        public BookContext(DbContextOptions<BookContext>options)
            : base(options)
        { 
        }

       // public virtual DbSet<Book> Book { get; set; }
        public object Books { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=H99PX52-SHEL\\SQLEXPRESS;Database=trainingTSQL;Trusted_Connection=True;MultipleActiveResultsets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.price)
            //    .IsRequired()
            //    .HasColumnName("Bkprice")
            //    .HasDefaultValue(200);
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }
        public object Orders { get; internal set; }
    }
}
