using ParkingLotApi.Contracts;
using ParkingLotApi.Data;
using ParkingLotApi.Models;
using ParkingLotApi.Repositories;

namespace ParkingLotApi.Services;


public class ParkingLotService
{
    private readonly ParkingLotRepository _parkingLotRepository;
    private readonly IGenericRepository<Reservation> _reservationRepository;

    public ParkingLotService(ParkingLotRepository parkingLotRepository,IGenericRepository<Reservation> reservationRepository )
    {
        _parkingLotRepository = parkingLotRepository;
        _reservationRepository = reservationRepository;
    }

    public async Task<Reservation> CreateReservation( ReservationRequest reservation)
    {
        var reservationEntity = new Reservation()
        {
            StartTime = reservation.StartTime,
            EndTime = reservation.EndTime,
            VehicleId = reservation.VehicleId,
            UserId = reservation.UserId,
            SpotReservations = new List<SpotReservation>()
            {  new SpotReservation()
                {
                    SpotId = new Guid(reservation.SpotId) ,
                    ReservationId =  new Guid() 
                }
            }
        };
        
       var result = await _reservationRepository.AddAsync(reservationEntity);

       return result;
    }

    public async Task<List<Spot?>> GetParkingSpots(string parkingLotId, int pageNumber, int pageSize)
    {
        var result = await _parkingLotRepository.GetParkingSpots(
            parkingLotId, pageNumber, pageSize);
        
        return result;
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