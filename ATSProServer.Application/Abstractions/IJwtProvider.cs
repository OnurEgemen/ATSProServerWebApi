using ATSProServer.Domain.AppEntities.Identity;

namespace ATSProServer.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user, List <string> roles);
    }
}


