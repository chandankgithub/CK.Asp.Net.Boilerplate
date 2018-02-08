using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CK.ABP.Roles.Dto;
using CK.ABP.Users.Dto;

namespace CK.ABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}