using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;
using Vehicle_Branding.DomainLL.Repository.IRepository;
using Vehicle_Branding.Services.IVehicle;

namespace Vehicle_Branding.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _V;
        public VehicleService(IVehicleRepository V)
        {
            _V = V;
        }
        public VehicleModelDTO CreateVehicle(VehicleModelDTO vehicle)
        {
            var vehicle1 = new VehicleModelDTO
            {
                VehicleName = vehicle.VehicleName,
                VIN_number = vehicle.VIN_number,
                FuelCapacity = vehicle.FuelCapacity,
                FuelReserveCapacity = vehicle.FuelReserveCapacity,
                MilegePerLiter = vehicle.MilegePerLiter,
                SeatingCapacity = vehicle.SeatingCapacity,
                Engine = vehicle.Engine,

            };
            return (_V.CreateVehicle(vehicle1));
        }

        public VehicleColorDTO CreateVehicleColor(VehicleColorDTO vehicleColor)
        {
            VehicleColorDTO vehicleColor1 = new VehicleColorDTO
            {
                vehicleColor_Id = vehicleColor.vehicleColor_Id,
                Vehicle_Color = vehicleColor.Vehicle_Color

            };
            return (_V.CreateVehicleColor(vehicleColor1));
        }

        public VehicleTransmissionDTO CreateVehicleTransmission(VehicleTransmissionDTO vehicle)
        {
            var type1 = new VehicleTransmissionDTO
            {
                Vehicle_Transmission_Id = vehicle.Vehicle_Transmission_Id,
                Vehicle_Transmission_Type = vehicle.Vehicle_Transmission_Type,
            };
            return (_V.CreateVehicleTransmission(type1));
        }

        public VehicleType1DTO CreateVehicleType(VehicleType1DTO vehicleType)
        {
            VehicleType1DTO vehicleType1 = new VehicleType1DTO
            {
                Vehicle_ID = vehicleType.Vehicle_ID,
                Vehicle_Type = vehicleType.Vehicle_Type,
            };
            return (_V.CreateVehicleType(vehicleType1));
        }

        public string DeleteVehicle(int id)
        {
            return(_V.DeleteVehicle(id));
        }

        public List<VehicleModelDTO> Get()
        {
            return(_V.Get());
        }

        public List<VehicleAndTypeAndTransmissionAndColor> GetDetails()
        {
            return (_V.GetDetails());
        }

        public List<VehicleAndTypeDTO> GetDetails2()
        {
            return(_V.GetDetails2());
        }

        public List<VehicleAndTransmissionDTO> GetDetails3()
        {
            return(_V.GetDetails3());
        }

        public VehicleModelDTO GetVehcileByName(string name)
        {
            return (_V.GetVehcileByName(name));
        }

        public VehicleModelDTO GetVehcileByVINNum(string VINNum)
        {
            return (_V.GetVehcileByVINNum(VINNum));
        }

        public VehicleModelDTO UpdateVehicle(VehicleModelDTO vehicle, int id)
        {
           return(_V.UpdateVehicle(vehicle, id));
        }
    }
}
