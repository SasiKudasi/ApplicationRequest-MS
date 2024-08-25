using ApplicationRequest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRequest.DataAccess
{
    public class ApplicationRequestDbContext : DbContext
    {
        public ApplicationRequestDbContext(DbContextOptions<ApplicationRequestDbContext> options)
            : base(options)
        {

        }
        public DbSet<RequestEntity> RequestEntities { get; set; }
    }
}
