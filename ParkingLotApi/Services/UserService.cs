using ParkingLotApi.Contracts;
using ParkingLotApi.Models;
using ParkingLotApi.Repositories;

namespace ParkingLotApi.Services;

public class UserService : IUserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
   public async Task<UserModel?> GetUserById(Guid id)
    {
        var result = await _userRepository.GetAsync(id);
        return new UserModel()
        {
            UserId = result.UserId,
            Username = result.Username,
            UserNumber = result.UserNumber,
            Email = result.Email,
            FirstName = result.FirstName,
            LastName = result.LastName,
            Address = result.Address,
            Country = result.Country,
            City = result.City,
            State = result.State,
            ZipCode = result.ZipCode,
            Phone = result.Phone,
            Vehicles = result.Vehicle
        };
    }
    
    
    public async Task<List<UserModel>> GetUsersPaginatedAsync(int pageNumber, int pageSize)
    {
        var resultList = await _userRepository.GetUsersPaginatedAsync( pageNumber,  pageSize);
        var userList = resultList.Select(v => new UserModel()
        {
            UserId = v.UserId,
            Username = v.Username,
            UserNumber = v.UserNumber,
            Email = v.Email,
            FirstName = v.FirstName,
            LastName = v.LastName,
            Address = v.Address,
            Country = v.Country,
            City = v.City,
            State = v.State,
            ZipCode = v.ZipCode,
            Phone = v.Phone,
            Vehicles = v.Vehicle
        });
        return userList.ToList();
    }

    public async Task<UserModel?> GetUserByNumberAsync(int userNumber)
    {
        var result = await _userRepository.GetUserByNumberAsync(userNumber);
        return new UserModel()
        {
            UserId = result.UserId,
            Username = result.Username,
            UserNumber = result.UserNumber,
            Email = result.Email,
            FirstName = result.FirstName,
            LastName = result.LastName,
            Address = result.Address,
            Country = result.Country,
            City = result.City,
            State = result.State,
            ZipCode = result.ZipCode,
            Phone = result.Phone,
            Vehicles = result.Vehicle
        };
    }

    public async Task<UserModel?> GetUserByUsernameAsync(string username)
    {
        var result = await _userRepository.GetUserByUsernameAsync(username);
        return new UserModel()
        {
            UserId = result.UserId,
            Username = result.Username,
            UserNumber = result.UserNumber,
            Email = result.Email,
            FirstName = result.FirstName,
            LastName = result.LastName,
            Address = result.Address,
            Country = result.Country,
            City = result.City,
            State = result.State,
            ZipCode = result.ZipCode,
            Phone = result.Phone,
            Vehicles = result.Vehicle
        };
    }
}