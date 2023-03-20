using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLL.Model.DTOS
{
    public class VehicleAndColorDTO
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VIN_number { get; set; }
        public string Engine { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelReserveCapacity { get; set; }
        public int MilegePerLiter { get; set; }
        public int SeatingCapacity { get; set; }
        public string Vehicle_Color { get; set; }
    }
}
