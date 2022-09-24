using System.ComponentModel.DataAnnotations;

namespace ConverterApp.Models
{
    public class Metrics
    {
        [Key]
        public int MetricsId { get; set; }

        [Required(ErrorMessage = "Source Unit Required")]
        public int SourceId { get; set; }

        [Required(ErrorMessage = "Target Unit Required")]
        public int TargetId { get; set; }

        [Required(ErrorMessage = "Calculation formula Required")]
        public string Formula { get; set; }
    }
}
