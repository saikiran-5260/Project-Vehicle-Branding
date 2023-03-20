using DomainLL.Model;

using Vehicle_Branding.Model;


namespace Vehicle_Branding.DomainLL.Repository.IRepository
{
    public interface IVehicleRepository
    {
        List<VehicleModel> Get();
        List<VehicleAndTypeAndTransmissionAndColor> GetDetails();
        List<VehicleAndType> GetDetails2();
        List<VehicleAndTransmission> GetDetails3();
        List<VehicleAndColor> GetDetails4();
        VehicleModel CreateVehicle(VehicleModel vehicle);
        VehicleType1 CreateVehicleType(VehicleType1 vehicleType);
        VehicleColor CreateVehicleColor(VehicleColor vehicleColor);
        VehicleTransmission CreateVehicleTransmission(VehicleTransmission vehicle);
        VehicleModel UpdateVehicle(VehicleModel vehicle,int id);
        VehicleModel GetVehcileByName(string name);
        VehicleModel GetVehcileByVINNum(string VINNum);

        string DeleteVehicle(int id);

    }
}
