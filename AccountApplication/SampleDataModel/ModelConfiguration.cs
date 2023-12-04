namespace SampleDataModel
{
    using AccountApplication.SampleDataModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureAccChartEntity(modelBuilder);
            ConfigureAcctDeptEntity(modelBuilder);
        }

        private static void ConfigureAccChartEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccCharts>().ToTable("Base.MyTable");
        }
        private static void ConfigureAcctDeptEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tDepts>().ToTable("Base.MyTable");
        }
    }
}