using Microsoft.EntityFrameworkCore;

namespace Meta.Api.Data
{
    public class CardContext : DbContext
    {
        public CardContext (
            DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<Meta.Api.Models.Card> Movie { get; set; }
    }
}