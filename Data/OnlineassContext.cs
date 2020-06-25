using onlineass.Models;
using Microsoft.EntityFrameworkCore;

namespace onlineass.Data
{
    public class OnlineassContext : DbContext
    {
        public OnlineassContext(DbContextOptions<OnlineassContext> opt) : base(opt)
        {

        }

        public DbSet<Topic>  Topics { get; set; }

        public DbSet<Question> Questions { get; set; }
        
    }
}