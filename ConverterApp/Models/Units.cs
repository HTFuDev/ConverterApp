using System.ComponentModel.DataAnnotations;

namespace ConverterApp.Models
{
    public class Units
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Unit name required")]
        public string UnitName { get; set; }
    }
}
