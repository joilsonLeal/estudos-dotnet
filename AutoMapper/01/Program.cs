using System;
using AutoMapper;

namespace mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                // origem , destino
                cfg.CreateMap<FooDto, Foo>();
            });

            var mapper = configuration.CreateMapper();

            var fooDto = new FooDto()
            {
                Name = "fernando",
            };

            var foo = mapper.Map<Foo>(fooDto);

            Console.WriteLine(foo.Name);
        }
    }

    class FooDto
    {
        public string Name { get; set; }
    }

    class Foo
    {
        public string Name { get; set; }
    }
}
