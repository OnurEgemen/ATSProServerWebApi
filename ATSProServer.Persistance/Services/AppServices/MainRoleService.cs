using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Domain.UnitOfWorks;
using System.Threading;

namespace ATSProServer.Persistance.Services.AppServices;

public sealed class MainRoleService : IMainRoleService
{
    private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
    private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository,
        IMainRoleQueryRepository mainRoleQueryRepository,
        IUnitOfWork unitOfWork)
    {
        _mainRoleCommandRepository = mainRoleCommandRepository;
        _mainRoleQueryRepository = mainRoleQueryRepository;
        _unitOfWork = unitOfWork;
    }

    
    public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
    {
        await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken 
        cancellationToken)
    {
        await _mainRoleCommandRepository.AddRangeAsync(newMainRoles,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<MainRole> GetByTitleAndFirmId(string title, string firmId,
        CancellationToken cancellationToken)
    {
       // if (firmId == null) return await _mainRoleQueryRepository.GetFirstByExpression(
       //     x => x.Title == title);
        return await _mainRoleQueryRepository.GetFirstByExpression(x=>x.Title == title &&
        x.FirmId == firmId, cancellationToken,false);
    }
}
