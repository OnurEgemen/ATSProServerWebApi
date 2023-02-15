using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm
{
    public sealed class CreateFirmCommandHandler :
        ICommandHandler<CreateFirmCommand, CreateFirmCommandResponse>
    {
        private readonly IFirmService _firmService;

        public CreateFirmCommandHandler(IFirmService firmService)
        {
            _firmService = firmService;
        }

        public async Task<CreateFirmCommandResponse> Handle(CreateFirmCommand request, CancellationToken cancellationToken)
        {
            Firm firm = await _firmService.GetFirmByName(request.FirmName);
            if (firm != null) throw new Exception("Bu şirket adı daha önce kullanılmıştır.");
            await _firmService.CreateFirm(request);
            return new();
        }
    }
}
