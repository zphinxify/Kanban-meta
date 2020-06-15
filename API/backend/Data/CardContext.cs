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

        public DbSet<Meta.Api.Models.Card> Cards { get; set; }
    }
}