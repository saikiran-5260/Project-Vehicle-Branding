using Microsoft.EntityFrameworkCore;

namespace Vehicle_Branding.Model.DTOS
{
    [Keyless]
    public class VehicleAndTypeAndTransmissionAndColorDTO
    {

        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VIN_number { get; set; }
        public string Engine { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelReserveCapacity { get; set; }
        public int MilegePerLiter { get; set; }
        public int SeatingCapacity { get; set; }
        public string Vehicle_Transmission_Type { get; set; }
        public string Vehicle_Type { get; set; }
        public string Vehicle_Color { get; set; }
    }
}
