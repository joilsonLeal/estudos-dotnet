using AutoMapper;
using Lib;
using System;

namespace MapLibrary
{
    public class Mapping : Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Style", "IDE0009:O acesso de membro deve ser qualificado.", Justification = "<Pendente>" )]
        public Mapping()
        {
            CreateMap<Anime, AnimeDto>()
                .ForMember(source => source.Id, opt => opt.MapFrom(destination => destination.Mal_id))
                .ForMember(source => source.Image, opt => opt.MapFrom(destination => destination.Image_url))
                .ForMember(source => source.Start, opt => opt.MapFrom(destination => destination.Airing_start));

            CreateMap<Source, Destination>()
                .Include<SourceChild, DestinationChild>();

            CreateMap<SourceChild, DestinationChild>();

            CreateMap<SourceChild, SourceChild>();

            CreateMap(typeof(GenericSource<>), typeof(GenericDestination<>));

        }
    }
}
