using ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSProServer.Application.Service.FirmServices
{
    public interface ICarService
    {
        Task CreateCarAsync(CreateCarCommand request);
    }
}
