using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Branding.Model.DTOS
{
    public class VehicleType1DTO
    {
        
        public int Vehicle_ID { get; set; }
        public string Vehicle_Type { get; set; }
    }
}
