using EHouseSys.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseSys.Application.UseCases.Users.CreateUser
{
    public interface ICreateUserUseCase
    {
        Task ExecuteAsync(CreateUserRequest request);
    }
}
