using ATSProServer.Application.Service.AppServices;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Persistance.Services.AppServices;
using ATSProServer.Persistance.Services.FirmServices;
using ATSProServer.Persistance;
using ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories;
using ATSProServer.Persistance.Repositories.FirmDbContext.CarRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using ATSProServer.Domain.UnitOfWorks;
using ATSProServer.Persistance.UnitOfWorks;
using ATSProServer.Domain;

namespace ATSProServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            #region Context - UnitOfWork
            services.AddScoped<IFirmDbUnitOfWork, FirmDbUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
                #region FirmDbContext
                services.AddScoped<ICarService, CarService>();
                #endregion

                #region AppDbContext
                services.AddScoped<IFirmService, FirmService>();
                services.AddScoped<IRoleService, RoleService>();
                services.AddScoped<IMainRoleService, MainRoleService>();
                

                #endregion
            #endregion

            #region Repositories
                #region FirmDbContext

                services.AddScoped<ICarCommandRepository,CarCommandRepository>();
                services.AddScoped<ICarQueryRepository, CarQueryRepository>();
                #endregion

            #region AppDbContext

                services.AddScoped<IFirmCommandRepository,FirmCommandRepository>();
                services.AddScoped<IFirmQueryRepository, FirmQueryRepository>();
                services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
                services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
                #endregion
            #endregion
        }
    }
}
