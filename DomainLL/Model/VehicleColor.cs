using System.ComponentModel.DataAnnotations;

namespace Vehicle_Branding.Model
{
    public class VehicleColor
    {
        [Key]
        public int vehicleColor_Id { get; set; }
        public string Vehicle_Color { get;set; }
    }
}
