using System.ComponentModel.DataAnnotations;

namespace bme_fon_talerin.Data.Models
{
    public class Sudoku
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public string GivenCells { get; set; }

        public string Solution { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
