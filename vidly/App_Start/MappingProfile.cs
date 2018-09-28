using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using vidly.Dtos;
using vidly.Models;

namespace vidly.App_Start
{
    public class MappingProfile : Profile
    {
        //Mapper.CreateMap<Customer, CustomerDto>();
        //Mapper.CreateMap<CustomerDto, Customer>();



        //var config = new MapperConfiguration(cfg => {
        //    cfg.CreateMap<Source, Dest>();
        //});

        //IMapper mapper = config.CreateMapper();
        //var source = new Source();
        //var dest = mapper.Map<Source, Dest>(source);
        public static void Run()
        {
            Mapper.Initialize(a =>
            {
                a.AddProfile<MappingProfile>();
            });

        }
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();

        }

    }
}