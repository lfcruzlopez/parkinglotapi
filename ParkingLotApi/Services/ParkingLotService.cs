using ParkingLotApi.Data;
using ParkingLotApi.Models;
using ParkingLotApi.Repositories;

namespace ParkingLotApi.Services;


public class ParkingLotService
{
    private readonly ParkingLotRepository _parkingLotRepository;

    public ParkingLotService(ParkingLotRepository parkingLotRepository)
    {
        _parkingLotRepository = parkingLotRepository;
    }


    public async Task<List<ParkingLotResponse?>> GetParkingLotAsync(int pageNumber, int pageSize)
    {
        var result = await _parkingLotRepository.GetParkingLotAsync(pageNumber, pageSize);

        return result.Select(n => new ParkingLotResponse()
        {
            Address = n.Address,
            Country = n.Country,
            City = n.City,
            State = n.State,
            ZipCode = n.ZipCode,
            Phone = n.Phone,
            Latitud = n.Latitud,
            
            
            Longitud = n.Longitud,
            Manager = n.Manager,
            //Spots = n.Spots,
            Status = n.Status,
            HoursOperations = n.HoursOperations,
            LocationName = n.LocationName,
            ParkingType = n.ParkingType,
            ParkingLotId = n.ParkingLotId
        }).ToList();
    }
}