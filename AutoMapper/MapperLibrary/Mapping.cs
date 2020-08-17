using AutoMapper;

namespace MapperLibrary
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Lib.Anime, Lib.AnimeDto>()
                .ForMember(source => source.Id, opt => opt.MapFrom(destination => destination.Mal_id))
                .ForMember(source => source.Image, opt => opt.MapFrom(destination => destination.Image_url))
                .ForMember(source => source.Start, opt => opt.MapFrom(destination => destination.Airing_start));
        }
    }
}
