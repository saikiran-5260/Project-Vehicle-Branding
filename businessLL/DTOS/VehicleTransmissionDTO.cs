using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Branding.Model.DTOS
{
    
    public class VehicleTransmissionDTO
    {
        public int Vehicle_Transmission_Id { get; set; }
        public string Vehicle_Transmission_Type { get; set; }

    }
}
