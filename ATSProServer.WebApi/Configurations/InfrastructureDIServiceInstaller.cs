using ATSProServer.Application.Abstractions;
using ATSProServer.Infrastructure.Authentication;

namespace ATSProServer.WebApi.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider,JwtProvider>();
        }
    }
}
