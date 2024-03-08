using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;
public class ParkingLot
{
    [Key]
    public Guid ParkingLotId { get; set; }
    [MaxLength(50)]
    public string LocationName { get; set; }
    
    [MaxLength(200)]
    public string? Address { get; set; }

    [MaxLength(50)]
    public string? Country { get; set; }

    [MaxLength(50)]
    public string? State { get; set; }

    [MaxLength(50)]
    public string? City { get; set; }

    [MaxLength(20)]
    public string? ZipCode { get; set; }
    
    [MaxLength(15)] 
    public string? Phone { get; set; } // New Phone property 
 
    public decimal? Latitud { get; set; }
    
    public decimal? Longitud { get; set; }
    
    [MaxLength(10)]
    public string? Status { get; set; }
    
    [MaxLength(50)]
    public string? HoursOperations { get; set; }

    [MaxLength(100)]
    public string? ParkingType { get; set; }
    
    [ForeignKey("ManagerId")]
    public Guid? ManagerId { get; set; }
    
    public Manager? Manager { get; set; }

    public ICollection<Spot> Spots { get; set; }  
}