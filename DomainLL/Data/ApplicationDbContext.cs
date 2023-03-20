using DomainLL.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Vehicle_Branding.Model;

namespace Vehicle_Branding.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<VehicleModel> Vehicles { get; set; }
        public DbSet<VehicleType1> VehicleType1 { get; set; }
        public DbSet<VehicleTransmission> VehicleTransmission { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }
        public DbSet<VehicleAndType> VehicleAndTypes { get; set; }

        public DbSet<VehicleAndTransmission> VehicleAndTransmissions { get; set; }
        public DbSet<VehicleAndTypeAndTransmissionAndColor> vehicleAndTypeAndTransmissionAndColors { get; set; }

        public DbSet<VehicleAndColor> vehicleAndColors { get; set; }
    }
}
