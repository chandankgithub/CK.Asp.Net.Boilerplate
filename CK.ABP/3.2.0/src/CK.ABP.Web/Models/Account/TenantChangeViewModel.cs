using Abp.AutoMapper;
using CK.ABP.Sessions.Dto;

namespace CK.ABP.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}