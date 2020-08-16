using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02.Model
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                CreateMap<Anime, AnimeDto>()
                    .ForMember(s => s.Start, opt => opt.MapFrom(d => d.Airing_start))
                    .ForMember(s => s.Id, opt => opt.MapFrom(d => d.Mal_id))
                    .ForMember(s => s.Image, opt => opt.MapFrom(d => d.Image_url));
            });
        }
    }
}
