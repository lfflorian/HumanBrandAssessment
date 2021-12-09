using AutoMapper;
using Database_client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Middleware
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            this.CreateMap<ClientDTO, Client>(MemberList.None)
                .ForMember(identity => identity.Name, dto => dto.MapFrom(model => model.Name))
                .ForMember(identity => identity.LastName, dto => dto.MapFrom(model => model.LastName))
                .ForMember(identity => identity.DPI, dto => dto.MapFrom(model => model.DPI));
        }
    }
}
