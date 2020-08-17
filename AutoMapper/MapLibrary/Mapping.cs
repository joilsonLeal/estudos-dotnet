using AutoMapper;
using Lib;
using System;

namespace MapLibrary
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Anime, AnimeDto>()
                .ForMember(source => source.Id, opt => opt.MapFrom(destination => destination.Mal_id))
                .ForMember(source => source.Image, opt => opt.MapFrom(destination => destination.Image_url))
                .ForMember(source => source.Start, opt => opt.MapFrom(destination => destination.Airing_start));
        }
    }
}
