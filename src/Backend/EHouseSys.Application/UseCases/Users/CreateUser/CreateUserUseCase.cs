
using EHouseSys.Application.DTOs.Users;
using EHouseSys.Domain.Entities;
using EHouseSys.Domain.Repositories;

namespace EHouseSys.Application.UseCases.Users.CreateUser;

public class CreateUserUseCase : ICreateUserUseCase
{
    private readonly IUserRepository _userRepository;

    public CreateUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task ExecuteAsync(CreateUserRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new ArgumentException("Name is required");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new ArgumentException("Email is required");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("Password is required");

        var user = new User
        {
            Name = request.Name,
            Email = request.Email,
            PasswordHash = request.Password
        };

        await _userRepository.AddAsync(user);
    }
}
