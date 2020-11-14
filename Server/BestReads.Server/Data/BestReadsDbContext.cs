using BestReads.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BestReads.Server.Data
{
    public class BestReadsDbContext : IdentityDbContext<User>
    {
        public BestReadsDbContext(DbContextOptions<BestReadsDbContext> options)
            : base(options)
        {
        }
    }
}
