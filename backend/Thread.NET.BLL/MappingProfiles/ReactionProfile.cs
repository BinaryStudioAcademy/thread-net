using AutoMapper;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.BLL.MappingProfiles
{
    public sealed class ReactionProfile : Profile
    {
        public ReactionProfile()
        {
            CreateMap<Reaction, ReactionDTO>();
            CreateMap<ReactionDTO, Reaction>();
        }
    }
}
