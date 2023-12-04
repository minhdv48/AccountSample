using SQLite.CodeFirst;
using System.Data.Entity;

namespace SampleDataModel
{
    public class DbInitializer: SqliteDropCreateDatabaseWhenModelChanges<SampleDbContext>
    {
        public DbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder, typeof(CustomHistory))
        { }

        protected override void Seed(SampleDbContext context)
        {
            // Here you can seed your core data if you have any.
        }
    }
}