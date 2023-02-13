using ATSProServer.Application.Service.AppServices;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Domain.Repositories.CarRepositories;
using ATSProServer.Domain;
using ATSProServer.Persistance.Repository.CarRepositories;
using ATSProServer.Persistance.Services.AppServices;
using ATSProServer.Persistance.Services.FirmServices;
using ATSProServer.Persistance;

namespace ATSProServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            #region Context - UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<IFirmService, FirmService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IRoleService,RoleService>();
            #endregion

            #region Repositories
            services.AddScoped<ICarCommandRepository, CarCommandRepository>();
            services.AddScoped<ICarQueryRepository, CarQueryRepository>();
            #endregion
        }
    }
}
