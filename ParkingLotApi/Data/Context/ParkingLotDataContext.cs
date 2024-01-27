using ParkingLotApi.Enum;
using ParkingLotApi.Models;

namespace ParkingLotApi.Data.Context;

using Microsoft.EntityFrameworkCore;

public class ParkingLotDataContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    
    public DbSet<Spot> Spots { get; set;}

    public DbSet<User> Users { get; set; }

    public DbSet<ParkingLot> ParkingLots { get; set; }
    
    
    public DbSet<Reservation> Reservations { get; set; } 
    
    public DbSet<Manager> Managers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your_Connection_String");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>();
        
        base.OnModelCreating(modelBuilder);
    }
}