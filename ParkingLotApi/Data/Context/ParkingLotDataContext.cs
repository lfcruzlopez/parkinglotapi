using ParkingLotApi.Enum;
using ParkingLotApi.Models;

namespace ParkingLotApi.Data.Context;

using Microsoft.EntityFrameworkCore;

public class ParkingLotDataContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    
    public DbSet<Spot> Spots { get; set;}

    public DbSet<User?> Users { get; set; }

    public DbSet<ParkingLot> ParkingLots { get; set; }
    
    
    public DbSet<Reservation> Reservations { get; set; } 
    
    public DbSet<Manager> Managers { get; set; }
    
    public ParkingLotDataContext(DbContextOptions<ParkingLotDataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Vehicle>();

        modelBuilder.Entity<Spot>();
        
        modelBuilder.Entity<User>();

        modelBuilder.Entity<ParkingLot>();

        modelBuilder.Entity<Reservation>();

        modelBuilder.Entity<Manager>();
        
        modelBuilder.Entity<SpotReservation>()
            .HasKey(ba => new { ba.SpotId, ba.ReservationId });

        // Depending on your needs, you can also configure the relationships here, for example:
        modelBuilder.Entity<SpotReservation>()
            .HasOne(ba => ba.Spot)
            .WithMany(b => b.SpotReservations)
            .HasForeignKey(ba => ba.SpotId);

        modelBuilder.Entity<SpotReservation>()
            .HasOne(ba => ba.Reservation)
            .WithMany(a => a.SpotReservations)
            .HasForeignKey(ba => ba.ReservationId);
        
        base.OnModelCreating(modelBuilder);
    }
}