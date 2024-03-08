using ParkingLotApi.Models;

namespace ParkingLotApi.Contracts;

public interface IUserService
{
    Task<List<UserModel>> GetUsersPaginatedAsync(int pageNumber, int pageSize);

    Task<UserModel?> GetUserByNumberAsync(int userNumber);

    Task<UserModel?> GetUserByUsernameAsync(string username);
    
    Task<UserModel?> GetUserById(Guid id);
}