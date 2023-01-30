using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm
{
    public sealed class CreateFirmHandler :
        IRequestHandler<CreateFirmRequest, CreateFirmResponse>
    {
        private readonly IFirmService _firmService;

        public CreateFirmHandler(IFirmService firmService)
        {
            _firmService = firmService;
        }

        public async Task<CreateFirmResponse> Handle(CreateFirmRequest request, CancellationToken cancellationToken)
        {
            Firm firm = await _firmService.GetFirmByName(request.FirmName);
            if (firm != null) throw new Exception("Bu şirket adı daha önce kullanılmıştır.");
            await _firmService.CreateFirm(request);
            return new();
        }
    }
}
