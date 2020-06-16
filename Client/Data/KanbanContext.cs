using Microsoft.EntityFrameworkCore;
using Client.Models;


namespace Client.Data
{
    public class KanbanContext : DbContext
    {
        public KanbanContext (
            DbContextOptions<KanbanContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Column> Columns { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<Column>().ToTable("Column");
        }
    }
}