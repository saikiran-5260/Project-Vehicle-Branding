using AutoMapper;
using DomainLL.Model.DTOS;
using Microsoft.EntityFrameworkCore;
using Vehicle_Branding.Data;
using Vehicle_Branding.DomainLL.Repository.IRepository;
using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;


namespace Vehicle_Branding.Repository
{
    public class Vehicle : IVehicleRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public Vehicle(ApplicationDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public List<VehicleModelDTO> Get()
        {
            List<VehicleModel> vehicleModels1 = _db.Vehicles.ToList();
            return (_mapper.Map<List<VehicleModelDTO>>(vehicleModels1));
        }
        public VehicleModelDTO GetVehcileByName(string name) 
        {
            VehicleModel Vehicle = _db.Vehicles.FirstOrDefault(x=>x.VehicleName== name);
            if (Vehicle == null)
            {
                return null;
            }
            return (_mapper.Map< VehicleModelDTO>(Vehicle));

        }
        public VehicleModelDTO GetVehcileByVINNum(string VINNum)
        {
            VehicleModel Vehicle = _db.Vehicles.FirstOrDefault(x => x.VIN_number == VINNum);
            if (Vehicle == null)
            {
                return null;
            }
            return (_mapper.Map<VehicleModelDTO>(Vehicle));

        }
        public VehicleModelDTO CreateVehicle(VehicleModelDTO model)
        {
            VehicleModel vehicle = _mapper.Map<VehicleModelDTO,VehicleModel>(model);
            _db.Vehicles.Add(vehicle);
            _db.SaveChanges();
            return (_mapper.Map<VehicleModel,VehicleModelDTO>(vehicle));
        }
        public VehicleModelDTO UpdateVehicle(VehicleModelDTO model,int id)
        {
            VehicleModel vehicle = _mapper.Map<VehicleModelDTO,VehicleModel>(model);    
            vehicle= _db.Vehicles.FirstOrDefault(x=>x.VehicleId==id);
            if (vehicle != null)
            {
                vehicle.VehicleId = id;
                vehicle.VehicleName = model.VehicleName;
                vehicle.Engine = model.Engine;
                vehicle.FuelReserveCapacity = model.FuelReserveCapacity;
                vehicle.FuelCapacity= model.FuelCapacity;
                vehicle.MilegePerLiter= model.MilegePerLiter;
                vehicle.SeatingCapacity= model.SeatingCapacity;
            }
            _db.Vehicles.Update(vehicle);
            _db.SaveChanges();
            return (_mapper.Map<VehicleModel, VehicleModelDTO>(vehicle));
        }

        public List<VehicleAndTypeAndTransmissionAndColor> GetDetails()
        {
            var vehicleAndTypeAndTransmissionAndColor  = (from Vehicles in _db.Vehicles
                                  join VehicleType1 in _db.VehicleType1 on Vehicles.VehicleId equals VehicleType1.Vehicle_ID 
                                  join VehicleTransmission in _db.VehicleTransmission on Vehicles.VehicleId equals VehicleTransmission.Vehicle_Transmission_Id
                                  join VehicleColor in _db.VehicleColors on Vehicles.VehicleId equals VehicleColor.vehicleColor_Id
                                   select new VehicleAndTypeAndTransmissionAndColor
                                   {
                                       
                                      VehicleId = Vehicles.VehicleId,
                                      VehicleName= Vehicles.VehicleName,
                                      VIN_number= Vehicles.VIN_number,
                                      Engine = Vehicles.Engine,
                                      FuelCapacity= Vehicles.FuelCapacity,
                                      FuelReserveCapacity= Vehicles.FuelReserveCapacity,
                                      MilegePerLiter = Vehicles.MilegePerLiter,
                                      SeatingCapacity= Vehicles.SeatingCapacity,
                                      Vehicle_Type = VehicleType1.Vehicle_Type,
                                      Vehicle_Transmission_Type = VehicleTransmission.Vehicle_Transmission_Type,
                                      Vehicle_Color = VehicleColor.Vehicle_Color
                                   }).ToList();
            return vehicleAndTypeAndTransmissionAndColor; 
        }

        public string DeleteVehicle(int id)
        {
            var vehicle = _db.Vehicles.FirstOrDefault(x=>x.VehicleId== id);
            _db.Vehicles.Remove(vehicle);
            _db.SaveChanges();
            return "Deleted Successfully";
        }

        public List<VehicleAndTypeDTO> GetDetails2()
        {
            var vehicleAndType1 = _db.VehicleAndTypes.FromSqlRaw("getdetails").ToList();
            //var vehicleAndType1 = (from Vehicles in _db.Vehicles
            //                       join VehcileType1 in _db.VehicleType1 on Vehicles.VehicleId equals VehcileType1.Vehicle_ID
            //                       select new VehicleAndType
            //                       {
            //                           VehicleId = Vehicles.VehicleId,
            //                           VehicleName = Vehicles.VehicleName,
            //                           VIN_number = Vehicles.VIN_number,
            //                           Vehicle_Type = VehcileType1.Vehicle_Type,
            //                           Engine = Vehicles.Engine,
            //                           FuelCapacity = Vehicles.FuelReserveCapacity,
            //                           MilegePerLiter = Vehicles.MilegePerLiter,
            //                           SeatingCapacity = Vehicles.SeatingCapacity,
            //                       }).ToList();
            return (_mapper.Map<List<VehicleAndTypeDTO>>(vehicleAndType1));
        }
        public List<VehicleAndTransmissionDTO> GetDetails3()
        {
            var vehiclesAndTransmission = _db.VehicleAndTransmissions.FromSqlRaw("GetDetailsOfVehiclesAndTransmission").ToList();
            //var vehicleAndType1 = (from Vehicles in _db.Vehicles
            //                       join VehicleTransmission in _db.VehicleTransmission on Vehicles.VehicleId equals VehicleTransmission.Vehicle_Transmission_Id
            //                       select new VehicleAndTransmission
            //                       {
            //                           VehicleId = Vehicles.VehicleId,
            //                           VehicleName = Vehicles.VehicleName,
            //                           VIN_number = Vehicles.VIN_number,
            //                           Vehicle_Transmission_Type = VehicleTransmission.Vehicle_Transmission_Type,
            //                           Engine = Vehicles.Engine,
            //                           FuelCapacity = Vehicles.FuelReserveCapacity,
            //                           MilegePerLiter = Vehicles.MilegePerLiter,
            //                           SeatingCapacity = Vehicles.SeatingCapacity,
            //                       }).ToList();
            //return vehicleAndType1;
            return (_mapper.Map<List<VehicleAndTransmissionDTO>>(vehiclesAndTransmission));
        }
        public VehicleTransmissionDTO CreateVehicleTransmission(VehicleTransmissionDTO vehicle)
        {
            VehicleTransmission vehicleTransmission = _mapper.Map<VehicleTransmissionDTO, VehicleTransmission>(vehicle);
            _db.VehicleTransmission.Add(vehicleTransmission);
            _db.SaveChanges();
            return (_mapper.Map<VehicleTransmission, VehicleTransmissionDTO>(vehicleTransmission));
        }

        public VehicleType1DTO CreateVehicleType(VehicleType1DTO vehicleType)
        {
            VehicleType1 vehicleType1 = _mapper.Map<VehicleType1DTO,VehicleType1>(vehicleType);
            _db.VehicleType1.Add(vehicleType1);
            _db.SaveChanges();
            VehicleType1DTO vehicleType12 = _mapper.Map<VehicleType1,VehicleType1DTO>(vehicleType1);
            return (vehicleType12);

        }

        public VehicleColorDTO CreateVehicleColor(VehicleColorDTO vehicleColor)
        {
            VehicleColor vehicle = _mapper.Map<VehicleColorDTO, VehicleColor>(vehicleColor);
            _db.VehicleColors.Add(vehicle);
            _db.SaveChanges();
            return (_mapper.Map<VehicleColor, VehicleColorDTO>(vehicle));

        }

        public List<VehicleAndColorDTO> GetDetails4()
        {
            var vehicleAndColor = _db.vehicleAndColors.FromSqlRaw("getDetailsOfVehicleAndColor").ToList();
            return (_mapper.Map<List<VehicleAndColorDTO>>(vehicleAndColor));
        }
    }
}
