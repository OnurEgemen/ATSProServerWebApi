using Microsoft.EntityFrameworkCore;
using ATSProServer.Domain.AppEntities.Identity;
using ATSProServer.Persistance.Context;
using ATSProServer.Persistance;

namespace ATSProServer.WebApi.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {

        private const string SectionName = "SqlServer";

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(SectionName);


            services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connectionString));

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddAutoMapper(typeof(AssemblyReference).Assembly);

        }
    }
}
