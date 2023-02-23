using ATSProServer.Application.Service.AppServices;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Domain;
using ATSProServer.Persistance.Services.AppServices;
using ATSProServer.Persistance.Services.FirmServices;
using ATSProServer.Persistance;
using ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories;
using ATSProServer.Persistance.Repositories.FirmDbContext.CarRepositories;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Persistance.Repositories.AppDbContext.FirmRepositories;

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
                #region FirmDbContext
                services.AddScoped<ICarService, CarService>();
                #endregion

                #region AppDbContext
                services.AddScoped<IFirmService, FirmService>();
                services.AddScoped<IRoleService, RoleService>();
                #endregion
            #endregion

            #region Repositories
            #region FirmDbContext

            services.AddScoped<ICarCommandRepository,CarCommandRepository>();
                services.AddScoped<ICarQueryRepository, CarQueryRepository>();
                #endregion
           
                #region AppDbContext

                services.AddScoped<IFirmCommandRepository, FirmCommandRepository>();
                services.AddScoped<IFirmQueryRepository, FirmQueryRepository>();
                #endregion
            #endregion
        }
    }
}
