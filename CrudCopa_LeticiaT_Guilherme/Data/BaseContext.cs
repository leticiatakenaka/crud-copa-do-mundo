using CrudCopa_LeticiaT_Guilherme.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudCopa_LeticiaT_Guilherme.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<Time> Time { get; set; }

    }
}
