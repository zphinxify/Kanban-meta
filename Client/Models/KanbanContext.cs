using Microsoft.EntityFrameworkCore;

namespace Client.Models {
    public class KanbanContext : DbContext {
        public KanbanContext(DbContextOptions<KanbanContext> options) : base(options) {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Column> Columns { get; set; }
    }
}