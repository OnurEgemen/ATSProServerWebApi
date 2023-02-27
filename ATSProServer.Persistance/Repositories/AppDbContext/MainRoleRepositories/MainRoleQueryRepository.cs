using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;

public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>,
    IMainRoleQueryRepository
{
    public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
