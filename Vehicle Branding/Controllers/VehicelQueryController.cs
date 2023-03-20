using DomainLL.Model.DTOS;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Branding.Model;
using Vehicle_Branding.Model.DTOS;
using Vehicle_Branding.Services.IVehicle;

namespace Vehicle_Branding.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class VehicelQueryController : Controller
    {
        private readonly IVehicleService _V;
        public VehicelQueryController(IVehicleService V)
        {
            _V = V;
        }

        [HttpGet]
        [Route("VehicleAndTypeAndTransmissionAndColor")]
        public ActionResult<List<VehicleAndTypeAndTransmissionAndColorDTO>> ShowDetails1()
        {
            var vehicleAndTypeAndColor = _V.GetDetails();
            return Ok(vehicleAndTypeAndColor);
        }
        [HttpGet]
        [Route("VehicleAndType")]
        public ActionResult<List<VehicleAndTypeDTO>> ShowDetails2()
        {
            List<VehicleAndTypeDTO> vehicleAndType = _V.GetDetails2();
            return Ok(vehicleAndType);
        }
        [HttpGet]
        [Route("VehicleAndTransmission")]
        public ActionResult<List<VehicleAndTransmissionDTO>> ShowDetails3()
        {
            var vehicleAndType = _V.GetDetails3();
            return Ok(vehicleAndType);
        }
        [HttpGet]
        [Route("VehicleAndColor")]
        public ActionResult<List<VehicleAndColorDTO>> ShowDetails4()
        {
            var vehicleAndColor = _V.GetDetails4();
            return Ok(vehicleAndColor);
        }
    }
}
