using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2026.Models
{
    //configuracao do entity framekORK
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }


}
