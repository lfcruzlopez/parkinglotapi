using ParkingLotApi.Data;

namespace ParkingLotApi.Models;

public class ParkingLotResponse
{

    public Guid ParkingLotId { get; set; }

    public string LocationName { get; set; }
    

    public string? Address { get; set; }


    public string? Country { get; set; }


    public string? State { get; set; }

    public string? City { get; set; }


    public string? ZipCode { get; set; }
    

    public string? Phone { get; set; } // New Phone property 
 
    public decimal? Latitud { get; set; }
    
    public decimal? Longitud { get; set; }

    public string? Status { get; set; }

    public string? HoursOperations { get; set; }

    public string? ParkingType { get; set; }
    
    public Manager? Manager { get; set; }

    public ICollection<Spot> Spots { get; set; }  
}