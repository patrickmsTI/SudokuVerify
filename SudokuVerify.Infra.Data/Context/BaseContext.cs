using Microsoft.EntityFrameworkCore;
using SudokuVerify.Domain.Entities;

namespace SudokuVerify.Infra.Data.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<SudokuChecked> SudokoCheked { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SudokuChecked>(c =>
            {
                c.Property(e => e.Id).ValueGeneratedOnAdd();
            });
        }

    }
}
