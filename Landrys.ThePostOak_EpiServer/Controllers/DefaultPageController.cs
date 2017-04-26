using System;
using System.Web.Mvc;
using EPiServer;
using Landrys.ThePostOak_EpiServer.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using Landrys.ThePostOak_EpiServer.Models.ViewModels;

namespace Landrys.ThePostOak_EpiServer.Controllers
{

    [TemplateDescriptor(Inherited = true)]
    public class DefaultPageController : PageControllerBase<SitePageData>
    {
        public ViewResult Index(SitePageData currentPage)
        {
            var model = CreateModel(currentPage);
            return View(string.Format("~/Views/{0}/Index.cshtml", currentPage.GetOriginalType().Name), model);
        }

        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}
