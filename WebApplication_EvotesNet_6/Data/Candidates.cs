using System.ComponentModel.DataAnnotations;

namespace WebApplication_EvotesNet_6.Data
{
    public class Candidates : BaseEntity
    {
        [Display(Name ="First Name")]
        public String? FirstName { get; set; }

        [Display(Name = "First Name")]
        public String? LastName { get; set; }
        public String? Constituency { get; set; }

    }
}
