using Abp.Web.Mvc.Views;

namespace CK.ABP.Web.Views
{
    public abstract class ABPWebViewPageBase : ABPWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPWebViewPageBase()
        {
            LocalizationSourceName = ABPConsts.LocalizationSourceName;
        }
    }
}