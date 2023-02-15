using ATSProServer.Application.Messaging;
using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.MigrateFirmDatabase
{
    public sealed record MigrateFirmDatabasesCommand (): ICommand<MigrateFirmDatabasesCommandResponse>
    
}
