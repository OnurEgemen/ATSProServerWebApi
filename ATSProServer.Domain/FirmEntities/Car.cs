using ATSProServer.Domain.Abstractions;

namespace ATSProServer.Domain.FirmEntities
{
    public sealed class Car : Entity
    {
        //ÖRNEK ENTITYLER
        public string CarId { get; set; }
        public string CarModel { get; set; }
        public string CarYear { get; set; }
        public string CarDetails { get; set; }
       
    }
}
