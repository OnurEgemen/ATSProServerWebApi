﻿using ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Domain;
using ATSProServer.Domain.FirmEntities;
using ATSProServer.Domain.Repositories.CarRepositories;
using ATSProServer.Persistance.Context;
using AutoMapper;

namespace ATSProServer.Persistance.Services.FirmServices
{
    public class CarService : ICarService
    {
        private readonly ICarCommandRepository _carCommandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private FirmDbContext _context;

        public CarService(ICarCommandRepository carCommandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _carCommandRepository = carCommandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateCarAsync(CreateCarRequest request)
        {
            _context = (FirmDbContext)_contextService.CreateDbContextInstance(request.FirmId);
            _carCommandRepository.SetDbContextInstance(_context);

            _unitOfWork.SetDbContextInstance(_context);
            Car car = _mapper.Map<Car>(request);

            car.CarId = Guid.NewGuid().ToString();

            await _carCommandRepository.AddAsync(car);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
