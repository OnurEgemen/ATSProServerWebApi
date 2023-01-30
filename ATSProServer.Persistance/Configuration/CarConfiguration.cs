using ATSProServer.Domain.FirmEntities;
using ATSProServer.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATSProServer.Persistance.Configuration
{
    public sealed class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable(TableName.Car);
            builder.HasKey(x => x.CarId);
        }
    }
}
