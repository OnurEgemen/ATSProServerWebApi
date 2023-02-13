namespace ATSProServer.WebApi.Configurations
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection service, IConfiguration configuration);
    }
}
