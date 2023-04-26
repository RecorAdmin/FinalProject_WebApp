using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_EvotesNet_6.Data
{
    public class VotersAllocations : BaseEntity
    {
        [ForeignKey("CandidatesId")]
        public Candidates Candidates { get; set; }
        public int CandidatesId { get; set; }
        public int VCount { get; set; }
    }
}
