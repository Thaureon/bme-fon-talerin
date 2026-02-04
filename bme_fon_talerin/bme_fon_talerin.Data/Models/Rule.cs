using System.ComponentModel.DataAnnotations;

namespace bme_fon_talerin.Data.Models
{
    public class Rule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
