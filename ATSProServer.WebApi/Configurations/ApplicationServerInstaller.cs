using ATSProServer.Application;
using MediatR;

namespace ATSProServer.WebApi.Configurations
{
    public class ApplicationServerInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);
        }
    }
}
