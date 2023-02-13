using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace ATSProServer.WebApi.Configurations
{
    public class PresentationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
    .AddApplicationPart(typeof(ATSProServer.Presentation.AssemblyReference).Assembly);



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();

            //Swagger Authorized Eklendi -- değişecek!
            services.AddSwaggerGen(setup =>
            {
                var jwtSecuritySheeme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** yourt JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                setup.AddSecurityDefinition(jwtSecuritySheeme.Reference.Id, jwtSecuritySheeme);
                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                 {
                      { jwtSecuritySheeme, Array.Empty<string>()}
                 });
            });
        
        }
    }
}
