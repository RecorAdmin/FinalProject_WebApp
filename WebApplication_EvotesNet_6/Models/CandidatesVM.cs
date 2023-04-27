using System.ComponentModel.DataAnnotations;

namespace WebApplication_EvotesNet_6.Models
{
    public class CandidatesVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display (Name ="Last Name")]
        public string? LastName { get; set; }
        public string? Constituency { get; set; }

    }
}
