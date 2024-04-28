using Microsoft.EntityFrameworkCore;

namespace BlogsCodeFirst.Database
{
    public class BlogSiteDbContext : DbContext
    {
        public BlogSiteDbContext()
        {

        }

        public BlogSiteDbContext(DbContextOptions<BlogSiteDbContext> options) :base(options)
        {

        }
    }
}
