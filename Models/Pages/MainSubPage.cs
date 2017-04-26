using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Landrys.ThePostOak_EpiServer.Models.Blocks;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Main-SubPage",
        GUID = "c4763d99-835b-4d8d-8109-8e18f5238288",
        Description = "Main SubPage Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class MainSubPage : SitePageData
    {
        [CultureSpecific]
        public virtual ContentArea ContentAreaHolder { get; set; }

        [CultureSpecific]
        public virtual ContentArea ContentAreaSlider { get; set; }

        [Display(Order = 205)]
        public virtual XhtmlString ContentHolder01 { get; set; }

        [CultureSpecific]
        public virtual ContentArea BlockImage01 { get; set; }

        [CultureSpecific]
        public virtual ContentArea BlockImage02 { get; set; }

        [CultureSpecific]
        public virtual ContentArea BlockImage03 { get; set; }

        [CultureSpecific]
        public virtual ContentArea BlockImage04 { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 400)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 450)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }
        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }
    }
}