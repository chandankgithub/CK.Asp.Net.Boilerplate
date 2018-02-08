using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CK.ABP.EntityFramework.Repositories
{
    public abstract class ABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPRepositoryBase(IDbContextProvider<ABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPRepositoryBase<TEntity> : ABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPRepositoryBase(IDbContextProvider<ABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
