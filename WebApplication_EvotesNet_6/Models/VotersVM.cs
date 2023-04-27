using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using WebApplication_EvotesNet_6.Data;

namespace WebApplication_EvotesNet_6.Models
{
    public class VotersVM
    {
        public int Id { get; set; }
        [Display(Name = "Voters ID#")]
        public int VotersIdNumber { get; set; }
        [Required]
        [Range(7,7, ErrorMessage ="Please Enter A Valid ID#")]

        [ForeignKey("CandidatesId")]
        public Candidates Candidates { get; set; }
        public int CandidatesId { get; set; }
    }
}
