using System.Linq;
using CK.ABP.EntityFramework;
using CK.ABP.MultiTenancy;

namespace CK.ABP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPDbContext _context;

        public DefaultTenantCreator(ABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
