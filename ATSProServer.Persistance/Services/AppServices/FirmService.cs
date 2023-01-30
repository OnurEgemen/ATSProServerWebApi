using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.Services.AppServices
{
    public sealed class FirmService : IFirmService
    {
        private readonly Func<AppDbContext, string, Task<Firm?>>
            GetFirmByNameCompiled =
            EF.CompileAsyncQuery((AppDbContext context, string name) =>
            context.Set<Firm>().FirstOrDefault(p => p.FirmName == name));

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public FirmService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task CreateFirm(CreateFirmRequest request)
        {
            Firm firm = _mapper.Map<Firm>(request);
            firm.Id = Guid.NewGuid().ToString();
            await _context.Set<Firm>().AddAsync(firm);
            await _context.SaveChangesAsync();
        }

        public async Task<Firm?> GetFirmByName(string name)
        {
            return await GetFirmByNameCompiled(_context,name);
        }

        public async Task MigrateFirmDatabases()
        {
            var firms = await _context.Set<Firm>().ToListAsync();
            foreach (var firm in firms)
            {
                var db = new FirmDbContext(firm);
                db.Database.Migrate();
            }
        }
    }
}