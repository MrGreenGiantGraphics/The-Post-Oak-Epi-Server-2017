using EPiServer.SpecializedProperties;
using Landrys.ThePostOak_EpiServer.Models.Blocks;
using System.Web;
using System.Web.Mvc;

namespace Landrys.ThePostOak_EpiServer.Models.ViewModels
{
    public class LayoutModel
    {
        public SiteLogotypeBlock Logotype { get; set; }
        public IHtmlString LogotypeLinkUrl { get; set; }
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
        public LinkItemCollection ProductPages { get; set; }
        public LinkItemCollection CompanyInformationPages { get; set; }
        public LinkItemCollection NewsPages { get; set; }
        public LinkItemCollection CustomerZonePages { get; set; }
        public bool LoggedIn { get; set; }
        public MvcHtmlString LoginUrl { get; set; }
        public MvcHtmlString LogOutUrl { get; set; }
        public MvcHtmlString SearchActionUrl { get; set; }
    }
}