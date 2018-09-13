using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Data.Entities.Enrolment, Responses.Enrolment>()
                .ForMember(x => x.SupplyAddress, dest => dest.MapFrom(y => y.SupplyAddress.HouseNumber + " " + y.SupplyAddress.StreetName));
        }
    }
}
