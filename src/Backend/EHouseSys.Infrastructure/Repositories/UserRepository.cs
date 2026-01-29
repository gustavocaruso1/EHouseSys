using EHouseSys.Domain.Entities;
using EHouseSys.Domain.Repositories;
using EHouseSys.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseSys.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EHouseSysDbContext _context;

        public UserRepository(EHouseSysDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
