using System.ComponentModel.DataAnnotations;

namespace Vehicle_Branding.Model.DTOS
{
    public class VehicleAndTransmissionDTO
    {

        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VIN_number { get; set; }
        public string Engine { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelReserveCapacity { get; set; }
        public int MilegePerLiter { get; set; } 
        public int SeatingCapacity { get; set; }//emplyee table fields
        public string Vehicle_Transmission_Type { get; set; } //company field company name
        //company address
    }
}
