using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CK.ABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}