using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;

public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>,
    IMainRoleCommandRepository
{
    public MainRoleCommandRepository(Context.AppDbContext contex) : base(contex)
    {

    }
}
