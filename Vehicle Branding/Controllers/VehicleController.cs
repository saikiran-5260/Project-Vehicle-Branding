using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Branding.Data;
using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;

using Vehicle_Branding.Services.IVehicle;

namespace Vehicle_Branding.Controllers
{
    [ApiController]
    
    public class VehicleController : Controller
    {
        private readonly IVehicleService _V;

        public VehicleController(IVehicleService V)
        {
            _V = V;
        }
        
        [HttpGet]
        [Route("ShowDetails")]
        public async Task<ActionResult<List<VehicleModelDTO>>> ShowDetails()
        {
            var vehicleModels =   _V.Get();
            return Ok(vehicleModels);
        }
        
        [HttpPost]
        [Route("PostVehicle")]
        public ActionResult<VehicleModelDTO> PostVehicle(VehicleModelDTO model)
        {
            var Vehicle = _V.CreateVehicle(model);
            return Ok(Vehicle);
        }
        [HttpPost]

        [Route("PostVehicleColor")]
        public ActionResult<VehicleColorDTO> PostVehicleColor(VehicleColorDTO vehicleColors)
        {
            VehicleColorDTO vehicleColors1 = _V.CreateVehicleColor(vehicleColors);
            return Ok(vehicleColors1);
        }


        [HttpPost]
        [Route("PostVehicleType")]
        public ActionResult<VehicleType1DTO> PostVehicleType(VehicleType1DTO model)
        {
            VehicleType1DTO Vehicle = _V.CreateVehicleType(model);
            return Ok(Vehicle);
        }
        [HttpPost]
        [Route("PostVehicleTransmission")]
        public ActionResult<VehicleTransmissionDTO> PostVehicleTransmission(VehicleTransmissionDTO model)
        {
            VehicleTransmissionDTO Vehicle = _V.CreateVehicleTransmission(model);
            return Ok(Vehicle);
        }
        [HttpPut]
        [Route("PutVehicle")]
        public ActionResult<VehicleModelDTO> PutVehicle(VehicleModelDTO model,int id)
        {
            var Vehicle  = _V.UpdateVehicle(model,id);
            return Ok(Vehicle);
        }
        
        [HttpGet]
        [Route("ShowDetailsByName")]
        public ActionResult<VehicleAndTypeAndTransmissionAndColorDTO> ShowDetailsByName(string name)
        {
            var vehicleAndType = _V.GetVehcileByName(name);
            return Ok(vehicleAndType);
        }
        [HttpGet]
        [Route("ShowDetailsByVINNum")]
        public ActionResult<VehicleAndTypeAndTransmissionAndColorDTO> ShowDetailsByVINNum(string VINNum)
        {
            var vehicleAndType = _V.GetVehcileByVINNum(VINNum);
            return Ok(vehicleAndType);
        }
        [HttpDelete]
        [Route("DeletVehicle")]
        public ActionResult<VehicleAndTypeAndTransmissionAndColorDTO> DeleteVehicle(int id)
        {
            var vehicleAndType = _V.DeleteVehicle(id);
            return Ok(vehicleAndType);
        }
    }
}
