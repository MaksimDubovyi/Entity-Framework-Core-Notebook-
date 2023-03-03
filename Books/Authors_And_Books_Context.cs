using Microsoft.EntityFrameworkCore;

namespace Books
{
    public class Authors_And_Books_Context : DbContext
    {
        public Authors_And_Books_Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<AuthorS> AuthorS_ { get; set; }
        public DbSet<Books> Books_ { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=DESKTOP-O9N6CR6\SQLEXPRESS;Database=Authors_And_Books_;Trusted_Connection=True;");
        }
    }
}
