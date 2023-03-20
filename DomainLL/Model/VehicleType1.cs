using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Branding.Model
{
    public class VehicleType1
    {
        [Key]
        public int Vehicle_ID { get; set; }
        public string Vehicle_Type { get; set; }
    }
}
