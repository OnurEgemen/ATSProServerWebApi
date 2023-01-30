using ATSProServer.Domain.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ATSProServer.Persistance.Context
{
    public sealed class FirmDbContext : DbContext
    {
        private string ConnectionString = "";
       
        public FirmDbContext(Firm firm = null)
        {
           
            if(firm!= null) 
            {
                if (firm.UserId == "")
                    ConnectionString = $"" +
                        $"Data Source={firm.ServerName};" +
                        $"Initial Catalog={firm.DatabaseName};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"TrustServerCertificate=False;" +
                        $"ApplicationIntent=ReadWrite;" +
                        $"MultiSubnetFailover=False";
                else
                    ConnectionString = $"" +
                        $"Data Source={firm.ServerName};" +
                        $"Initial Catalog={firm.DatabaseName} " +
                        $"UserId{firm.UserId};" +
                        $"Password{firm.Password};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"TrustServerCertificate=False;" +
                        $"ApplicationIntent=ReadWrite;" +
                        $"MultiSubnetFailover=False";
            }
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);


        public class FirmDbContextFactory : IDesignTimeDbContextFactory<FirmDbContext>
        {
           

            public FirmDbContext CreateDbContext(string[] args)
            {
                
                return new FirmDbContext();
            }
        }
    }
}
