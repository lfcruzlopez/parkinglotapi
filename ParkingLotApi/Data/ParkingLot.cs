using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;
public class ParkingLot
{
    [Key]
    public Guid ParkingLotId { get; set; }

    [MaxLength(200)]
    public string Address { get; set; }

    [MaxLength(50)]
    public string Country { get; set; }

    [MaxLength(50)]
    public string State { get; set; }

    [MaxLength(50)]
    public string City { get; set; }

    [MaxLength(20)]
    public string ZipCode { get; set; }
    
    
    [MaxLength(50)]
    public string Location { get; set; }

    [MaxLength(50)]
    public string ParkingType { get; set; }
    
    [ForeignKey("ManagerId")]
    public Guid ManagerId { get; set; }

    public List<Spot> Spots { get; set; } = new List<Spot>();
}