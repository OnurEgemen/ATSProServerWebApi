using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Domain.UnitOfWorks;
using ATSProServer.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.Services.AppServices
{
    public sealed class FirmService : IFirmService
    {
        private readonly IFirmCommandRepository _firmCommandRepository;
        private readonly IFirmQueryRepository _firmQueryRepository;
        private readonly IAppUnitOfWork _appUnitOfWork;
        private readonly IMapper _mapper;

        public FirmService(IMapper mapper, IFirmCommandRepository firmCommandRepository,
            IFirmQueryRepository firmQueryRepository, IAppUnitOfWork appUnitOfWork)
        {

            _mapper = mapper;
            _firmCommandRepository = firmCommandRepository;
            _firmQueryRepository = firmQueryRepository;
            _appUnitOfWork = appUnitOfWork;
        }

        public async Task CreateFirm(CreateFirmCommand request, 
            CancellationToken cancellationToken)
        {
            Firm firm = _mapper.Map<Firm>(request);
            firm.Id = Guid.NewGuid().ToString();
            await _firmCommandRepository.AddAsync(firm,cancellationToken);
            await _appUnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Firm?> GetFirmByName(string name)
        {
            return await _firmQueryRepository.GetFirstByExpression(x=>x.FirmName== name);
        }

        public async Task MigrateFirmDatabases()
        {
            var firms = await _firmQueryRepository.GetAll().ToListAsync();
            foreach (var firm in firms)
            {
                var db = new FirmDbContext(firm);
                db.Database.Migrate();
            }
        }
    }
}