using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CK.ABP.MultiTenancy.Dto;

namespace CK.ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
