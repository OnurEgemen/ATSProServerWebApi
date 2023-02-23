using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSProServer.Domain.AppEntities
{
    public sealed class MainRoleAndUserRelationship : Entity
    {
        [ForeignKey ("AppUser")]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }


        [ForeignKey("MainRole")]
        public string MainRoleId { get; set; }
        public MainRole MainRole { get; set; }

        [ForeignKey ("Firm")]
        public string FirmId { get; set; }
        public Firm Firm { get; set; }
    }
}
