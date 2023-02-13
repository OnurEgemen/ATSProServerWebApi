using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.AppEntities.Identity;
using ATSProServer.Domain.FirmEntities;
using AutoMapper;

namespace ATSProServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateFirmRequest, Firm>();

            CreateMap<CreateCarRequest, Car>();

            CreateMap<CreateRoleRequest, AppRole>();
        }
    }
}
