using System.ComponentModel.DataAnnotations;

namespace ConverterApp.ViewModel
{
    public class ConverterViewModel
    {
        [Required(ErrorMessage = "Source unit required")]
        public int SourceUnit { get; set; }

        [Required(ErrorMessage = "Target unit required")]
        public int TargetUnit { get; set; }

        [Required(ErrorMessage = "Value unit required")]
        public double Value { get; set; }
    }
}
