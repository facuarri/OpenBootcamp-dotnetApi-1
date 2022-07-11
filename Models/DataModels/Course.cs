using System.ComponentModel.DataAnnotations;

namespace openBootcamp_aspNetApi_ejercicio1.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string LongDescription { get; set; } = string.Empty;
        [Required]
        public string TargetAudience { get; set; } = string.Empty;
        [Required]
        public string Goals { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        public enum Nivel { Basic, Intermediate, Advanced};
    }
}
