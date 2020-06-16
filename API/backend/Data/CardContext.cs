using Microsoft.EntityFrameworkCore;
using Meta.Api.Models;


namespace Meta.Api.Data
{
    public class CardContext : DbContext
    {
        public CardContext (
            DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
        }
    }
}