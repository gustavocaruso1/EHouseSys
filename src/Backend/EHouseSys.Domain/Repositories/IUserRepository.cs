using EHouseSys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseSys.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}
