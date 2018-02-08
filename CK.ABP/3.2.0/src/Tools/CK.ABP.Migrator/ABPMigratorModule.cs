using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CK.ABP.EntityFramework;

namespace CK.ABP.Migrator
{
    [DependsOn(typeof(ABPDataModule))]
    public class ABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}