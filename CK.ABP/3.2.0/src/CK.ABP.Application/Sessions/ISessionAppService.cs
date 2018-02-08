using System.Threading.Tasks;
using Abp.Application.Services;
using CK.ABP.Sessions.Dto;

namespace CK.ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
