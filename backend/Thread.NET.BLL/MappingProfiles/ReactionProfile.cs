using AutoMapper;
using Thread.NET.Common.DTO.Like;
using Thread.NET.DAL.Entities.Abstract;

namespace Thread.NET.BLL.MappingProfiles
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
