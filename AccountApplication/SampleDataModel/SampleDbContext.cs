using AccountApplication.SampleDataModel;
using System.Data.Common;
using System.Data.Entity;

namespace SampleDataModel
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(string nameOrConnectionString)
             : base(nameOrConnectionString)
        {
            Configure();
        }

        public SampleDbContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
            Configure();
        }

        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<AccCharts> AccCharts { get; set; }
        public DbSet<tDepts> tDepts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
            modelBuilder.Entity<AccCharts>().ToTable("AccChart");
            modelBuilder.Entity<tDepts>().ToTable("tDept");
            var initializer = new DbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }
}