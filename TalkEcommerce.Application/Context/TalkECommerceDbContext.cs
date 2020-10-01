using Microsoft.EntityFrameworkCore;
using TalkEcommerce.Entities;

namespace TalkEcommerce.Context
{
    public class TalkECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
