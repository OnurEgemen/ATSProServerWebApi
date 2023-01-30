using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Domain.AppEntities;
using AutoMapper;

namespace ATSProServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateFirmRequest, Firm>().ReverseMap();
        }
    }
}
