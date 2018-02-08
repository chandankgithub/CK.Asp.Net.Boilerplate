using System.Threading.Tasks;
using Abp.Application.Services;
using CK.ABP.Configuration.Dto;

namespace CK.ABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}