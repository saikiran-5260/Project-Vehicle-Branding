using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;
using Vehicle_Branding.DomainLL.Repository.IRepository;
using Vehicle_Branding.Services.IVehicle;
using DomainLL.Model.DTOS;
using AutoMapper;

namespace Vehicle_Branding.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _V;
        private readonly IMapper _mapper;
        public VehicleService(IVehicleRepository V,IMapper mapper)
        {
            _V = V;
            _mapper = mapper;
        }
        public VehicleModelDTO CreateVehicle(VehicleModelDTO vehicle)
        {
            var Vehicle1 = _mapper.Map<VehicleModelDTO, VehicleModel>(vehicle);
            VehicleModel vehicle1 = new()
            {
                VehicleName = vehicle.VehicleName,
                VIN_number = vehicle.VIN_number,
                FuelCapacity = vehicle.FuelCapacity,
                FuelReserveCapacity = vehicle.FuelReserveCapacity,
                MilegePerLiter = vehicle.MilegePerLiter,
                SeatingCapacity = vehicle.SeatingCapacity,
                Engine = vehicle.Engine,

            };
            VehicleModel vehicle2 = _V.CreateVehicle(vehicle1);
            return (_mapper.Map<VehicleModel,VehicleModelDTO>(vehicle2));
        }

        public VehicleColorDTO CreateVehicleColor(VehicleColorDTO vehicleColor)
        {
            var vehicleColor1 = _mapper.Map<VehicleColorDTO, VehicleColor>(vehicleColor);
            vehicleColor1 = new VehicleColor
            {
                vehicleColor_Id = vehicleColor.vehicleColor_Id,
                Vehicle_Color = vehicleColor.Vehicle_Color
            };
            VehicleColor vehicleColor2 = _V.CreateVehicleColor(vehicleColor1);
            return (_mapper.Map<VehicleColor,VehicleColorDTO>(vehicleColor2));
        }

        public VehicleTransmissionDTO CreateVehicleTransmission(VehicleTransmissionDTO vehicle)
        {
            var type1 = _mapper.Map<VehicleTransmissionDTO, VehicleTransmission>(vehicle);
             type1 = new VehicleTransmission
            {
                Vehicle_Transmission_Id = vehicle.Vehicle_Transmission_Id,
                Vehicle_Transmission_Type = vehicle.Vehicle_Transmission_Type,
            };
            VehicleTransmission type2 = _V.CreateVehicleTransmission(type1);
            return (_mapper.Map<VehicleTransmission,VehicleTransmissionDTO>(type2));
        }

        public VehicleType1DTO CreateVehicleType(VehicleType1DTO vehicleType)
        {
            var vehicleType1 = _mapper.Map<VehicleType1DTO, VehicleType1>(vehicleType);
            vehicleType1 = new VehicleType1
            {
                Vehicle_ID = vehicleType.Vehicle_ID,
                Vehicle_Type = vehicleType.Vehicle_Type,
            };
            VehicleType1 vehicleType2 = _V.CreateVehicleType(vehicleType1);
            return (_mapper.Map<VehicleType1, VehicleType1DTO>(vehicleType2));
        }

        public string DeleteVehicle(int id)
        {
            return(_V.DeleteVehicle(id));
        }

        public List<VehicleModelDTO> Get()
        {
            List<VehicleModel> vehicleModels= _V.Get();
            return (_mapper.Map<List<VehicleModelDTO>>(vehicleModels));
        }

        public List<VehicleAndTypeAndTransmissionAndColorDTO> GetDetails()
        {
            var details = _V.GetDetails();
            return (_mapper.Map<List<VehicleAndTypeAndTransmissionAndColorDTO>>(details));
        }

        public List<VehicleAndTypeDTO> GetDetails2()
        {
            var vehicleAndType = _V.GetDetails2();
            return(_mapper.Map<List<VehicleAndTypeDTO>>(vehicleAndType));
        }

        public List<VehicleAndTransmissionDTO> GetDetails3()
        {
           var vehicleAndTransmission  = _V.GetDetails3();
           var vehicleAndTransmission1 = _mapper.Map<List<VehicleAndTransmissionDTO>>(vehicleAndTransmission);
            return (vehicleAndTransmission1);
        }

        public List<VehicleAndColorDTO> GetDetails4()
        {
            var vehicleAndColor = _V.GetDetails4();
            return (_mapper.Map<List<VehicleAndColorDTO>>(vehicleAndColor));
        }

        public VehicleModelDTO GetVehcileByName(string name)
        {
            var model = _V.GetVehcileByName(name);
            return (_mapper.Map<VehicleModelDTO>(model));
        }

        public VehicleModelDTO GetVehcileByVINNum(string VINNum)
        {
            var model = _V.GetVehcileByVINNum(VINNum);
            return (_mapper.Map<VehicleModelDTO>(model));
        }

        public VehicleModelDTO UpdateVehicle(VehicleModelDTO vehicle, int id)
        {
            var model1 = _mapper.Map<VehicleModelDTO,VehicleModel>(vehicle);
            var model = _V.UpdateVehicle(model1, id);
            return (_mapper.Map<VehicleModel, VehicleModelDTO>(model));
        }
    }
}
