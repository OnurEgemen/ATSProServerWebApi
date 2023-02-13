using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarRequest : IRequest<CreateCarResponse>
    {
        public string CarId { get; set; }
        public string CarModel { get; set; }
        public string CarYear { get; set; }
        public string CarDetails { get; set; }
        public string FirmId { get; set; }

    }
}
