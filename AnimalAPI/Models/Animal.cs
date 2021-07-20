using System.ComponentModel.DataAnnotations;

namespace AnimalAPI.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        [Required]
        [StringLength(20)]
        public string Gender { get; set; }
        [Required]
        public string Behavior { get; set; }
        [Required]
        public string DateAdded { get; set; }
    }
}