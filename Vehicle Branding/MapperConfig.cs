using AutoMapper;
using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;

namespace Vehicle_Branding
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMapper()
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<VehicleAndTransmission,VehicleAndTransmissionDTO>().ReverseMap();
                config.CreateMap<VehicleAndType,VehicleAndTypeDTO>().ReverseMap();
                config.CreateMap<VehicleAndTypeAndTransmissionAndColor,VehicleAndTypeAndTransmissionAndColorDTO>().ReverseMap();
                config.CreateMap<VehicleColor,VehicleColorDTO>().ReverseMap();
                config.CreateMap<VehicleModel,VehicleModelDTO>().ReverseMap();
                config.CreateMap<VehicleTransmission,VehicleTransmissionDTO>().ReverseMap();
                config.CreateMap<VehicleType1,VehicleType1DTO>().ReverseMap();
            });
            return mapper;
        }
    }
}
