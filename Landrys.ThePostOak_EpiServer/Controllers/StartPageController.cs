using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Landrys.ThePostOak_EpiServer.Models.Pages;
using Landrys.ThePostOak_EpiServer.Models.ViewModels;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            if (SiteDefinition.Current.StartPage.CompareToIgnoreWorkID(currentPage.ContentLink))
            // Check if it is the StartPage or just a page of the StartPage type.
            {
                //Connect the view models logotype property to the start page's to make it editable
                var editHints = ViewData.GetEditHints<PageViewModel<StartPage>, StartPage>();
                editHints.AddConnection(m => m.Layout.Logotype, p => p.SiteLogotype);
            }

            return View(model);
        }

    }
}