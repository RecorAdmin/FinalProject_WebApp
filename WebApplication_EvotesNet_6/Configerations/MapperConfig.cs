using AutoMapper;
using WebApplication_EvotesNet_6.Data;
using WebApplication_EvotesNet_6.Models;

namespace WebApplication_EvotesNet_6.Configerations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Candidates, CandidatesVM>().ReverseMap();
        }
    }
}
