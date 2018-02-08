using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CK.ABP.Roles.Dto;

namespace CK.ABP.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
