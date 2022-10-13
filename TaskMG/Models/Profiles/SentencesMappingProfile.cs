using AutoMapper;
using TaskMG.Models.DTOs;

namespace TaskMG.Models.Profiles
{
    public class SentencesMappingProfile : Profile
    {
        public SentencesMappingProfile()
        {
            CreateMap<Sentence, SentenceDto>();
            CreateMap<SentenceDto, Sentence>();
        }
    }
}
