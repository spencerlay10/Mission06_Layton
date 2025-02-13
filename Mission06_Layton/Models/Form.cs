using System.ComponentModel.DataAnnotations;

namespace Mission06_Layton.Models
{
    // Creates a Form class that sets variables for the database
    public class Form
    {
        [Key] // Sets the primary key
        [Required] // Sets the field as required
        public int MovieID { get; set; } 
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        
        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")] // Sets the max length of the field
        public string? Notes { get; set; }
    }
}
