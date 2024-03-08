using ParkingLotApi.Data;

namespace ParkingLotApi.Contracts;

public interface IUserRepository
{
     Task<List<User?>> GetUsersPaginatedAsync(int pageNumber, int pageSize);

     Task<User?> GetUserByNumberAsync(int userNumber);

     Task<User?> GetUserByUsernameAsync(string username);
}