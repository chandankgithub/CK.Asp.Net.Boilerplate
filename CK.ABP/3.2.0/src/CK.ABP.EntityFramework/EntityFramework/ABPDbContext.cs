using System.Data.Common;
using Abp.Zero.EntityFramework;
using CK.ABP.Authorization.Roles;
using CK.ABP.Authorization.Users;
using CK.ABP.MultiTenancy;

namespace CK.ABP.EntityFramework
{
    public class ABPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPDbContext since ABP automatically handles it.
         */
        public ABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
