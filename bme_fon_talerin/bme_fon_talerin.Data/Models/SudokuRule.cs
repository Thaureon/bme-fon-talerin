using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_talerin.Data.Models
{
    public class SudokuRule
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int SudokuId { get; set; }
        [ForeignKey(nameof(SudokuId))]
        public virtual Sudoku Sudoku { get; set; }

        [Required]
        public int RuleId { get; set; }
        [ForeignKey(nameof(RuleId))]
        public virtual Rule Rule { get; set; }

        [Required]
        public string Cells { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
