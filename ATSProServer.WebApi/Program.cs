using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities.Identity;
using ATSProServer.Persistance.Context;
using ATSProServer.Persistance.Services.AppServices;
using ATSProServer.Presentation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddIdentity<AppUser,AppRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IFirmService, FirmService>();


builder.Services.AddMediatR(typeof(ATSProServer.Application.AssemblyReference).Assembly);


builder.Services.AddAutoMapper(typeof(ATSProServer.Persistance.AssemblyReference).Assembly);


builder.Services.AddControllers()
    .AddApplicationPart(typeof(AssemblyReference).Assembly);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Swagger Authorized Eklendi -- deðiþecek!
builder.Services.AddSwaggerGen(setup =>
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
