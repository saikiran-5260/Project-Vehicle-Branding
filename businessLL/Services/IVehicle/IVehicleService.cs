using Vehicle_Branding.Model;
using Vehicle_Branding.DomainLL.Repository.IRepository;
using DomainLL.Model.DTOS;
using Vehicle_Branding.Model.DTOS;

namespace Vehicle_Branding.Services.IVehicle
{
    public interface IVehicleService
    {
        List<VehicleModelDTO> Get();
        List<VehicleAndTypeAndTransmissionAndColorDTO> GetDetails();
        List<VehicleAndTypeDTO> GetDetails2();
        List<VehicleAndTransmissionDTO> GetDetails3();
        List<VehicleAndColorDTO> GetDetails4();
        VehicleModelDTO CreateVehicle(VehicleModelDTO vehicle);
        VehicleType1DTO CreateVehicleType(VehicleType1DTO vehicleType);
        VehicleColorDTO CreateVehicleColor(VehicleColorDTO vehicleColor);
        VehicleTransmissionDTO CreateVehicleTransmission(VehicleTransmissionDTO vehicle);
        VehicleModelDTO UpdateVehicle(VehicleModelDTO vehicle, int id);
        VehicleModelDTO GetVehcileByName(string name);
        VehicleModelDTO GetVehcileByVINNum(string VINNum);

        string DeleteVehicle(int id);

    }
}
