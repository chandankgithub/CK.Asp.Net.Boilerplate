using System.Threading.Tasks;
using Abp.Application.Services;
using CK.ABP.Authorization.Accounts.Dto;

namespace CK.ABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
