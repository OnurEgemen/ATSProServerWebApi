using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSProServer.Domain.AppEntities
{
    public class UserAndFirmRelationship : Entity
    {
        [ForeignKey("AppUser")]
        
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("Firm")]
        public string FirmId { get; set; }
        public Firm Firm { get; set; }

    }
}
