using EHouseSys.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseSys.Infrastructure.Data.Context
{
    public class EHouseSysDbContext : DbContext
    {
        public EHouseSysDbContext(DbContextOptions<EHouseSysDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
    }
}
