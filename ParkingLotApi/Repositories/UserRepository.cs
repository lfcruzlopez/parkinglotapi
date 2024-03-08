using Microsoft.EntityFrameworkCore;
using ParkingLotApi.Contracts;
using ParkingLotApi.Data;
using ParkingLotApi.Data.Context;

namespace ParkingLotApi.Repositories;

public class UserRepository: GenericRepository<User>, IUserRepository
{
    private readonly ParkingLotDataContext _context;
    
    public UserRepository(ParkingLotDataContext context) : base(context)
    {
        _context = context;
    }
    
    public async Task<User?> GetUserByUsernameAsync(string username)
    {
        return await _context.Users.Include( users => users.Vehicle).FirstOrDefaultAsync(u => u.Username == username);
    }
    
    public async Task<User?> GetUserByNumberAsync(int userNumber)
    {
        return await _context.Users.Include(users => users.Vehicle).FirstOrDefaultAsync(u => u.UserNumber == userNumber);
    }
    
    public async Task<List<User?>> GetUsersPaginatedAsync(int pageNumber, int pageSize)
    {
        return await _context.Users.Include(users => users.Vehicle)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}