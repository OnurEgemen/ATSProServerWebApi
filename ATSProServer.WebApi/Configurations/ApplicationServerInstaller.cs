using ATSProServer.Application;
using ATSProServer.Application.Behaviour;
using FluentValidation;
using MediatR;

namespace ATSProServer.WebApi.Configurations
{
    public class ApplicationServerInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,>));

            services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    }
}
