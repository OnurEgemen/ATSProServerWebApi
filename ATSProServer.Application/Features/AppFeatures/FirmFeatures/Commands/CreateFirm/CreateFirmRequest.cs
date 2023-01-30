using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm
{
    public sealed class CreateFirmRequest : IRequest<CreateFirmResponse>
    {
        public string FirmName { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
