using Microsoft.EntityFrameworkCore;
using ParkingLotApi.Data;
using ParkingLotApi.Data.Context;

namespace ParkingLotApi.Repositories;

    public class ParkingLotRepository: GenericRepository<ParkingLot>
    {
        private readonly ParkingLotDataContext _context;

        public ParkingLotRepository(ParkingLotDataContext context) : base(context)
        {
            _context = context;
        }
        
        
        public async Task<List<ParkingLot?>> GetParkingLotAsync(int pageNumber, int pageSize)
        {
            return (await _context.ParkingLots.Include(pl => pl.Spots)
                .Include( pl => pl.Manager)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync())!;
        }
        
    }
