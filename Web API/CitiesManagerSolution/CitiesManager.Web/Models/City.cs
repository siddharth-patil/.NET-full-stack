using System.ComponentModel.DataAnnotations;

namespace CitiesManager.Web.Models
{
    public class City
    {
        [Key]
        public Guid CityID { get; set; }

        [Required(ErrorMessage ="City Name is required")]
        public string? CityName{ get; set; }
    }
}
