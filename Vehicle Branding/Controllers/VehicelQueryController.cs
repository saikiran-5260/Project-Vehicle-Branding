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
        [Route("ShowDetails1")]
        public ActionResult<List<VehicleAndTypeAndTransmissionAndColor>> ShowDetails1()
        {
            var vehicleAndTypeAndColor = _V.GetDetails();
            return Ok(vehicleAndTypeAndColor);
        }
        [HttpGet]
        [Route("ShowDetails2")]
        public ActionResult<List<VehicleAndTypeDTO>> ShowDetails2()
        {
            var vehicleAndType = _V.GetDetails2();
            return Ok(vehicleAndType);
        }
        [HttpGet]
        [Route("ShowDetails3")]
        public ActionResult<List<VehicleAndTransmissionDTO>> ShowDetails3()
        {
            var vehicleAndType = _V.GetDetails3();
            return Ok(vehicleAndType);
        }
        [HttpGet]
        [Route("ShowDetails4")]
        public ActionResult<List<VehicleAndColorDTO>> ShowDetails4()
        {
            var vehicleAndColor = _V.GetDetails4();
            return Ok(vehicleAndColor);
        }
    }
}
