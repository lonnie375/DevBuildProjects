using System.ComponentModel.DataAnnotations;

namespace InstrumentsDemo.Models
{
    public class Instrument
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Range(1950, 2022, ErrorMessage="Year must be from 1950 - 2022")]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}
