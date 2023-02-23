using ATSProServer.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSProServer.Domain.AppEntities
{
    public sealed class MainRole : Entity
    {
        public string Title { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }

        [ForeignKey("Firm")]
        public string FirmId { get; set; }
        public Firm? Firm { get; set; }

    }
}
