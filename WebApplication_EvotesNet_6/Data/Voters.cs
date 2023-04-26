using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_EvotesNet_6.Data
{
    public class Voters : BaseEntity
    {
        [Display(Name ="Voters ID#")]
       public int VotersIdNumber { get; set; }
        [ForeignKey("CandidatesId")]
        public Candidates Candidates { get; set; }
        public int CandidatesId {get; set; }
    }
}
