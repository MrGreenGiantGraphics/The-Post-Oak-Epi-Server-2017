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
        DisplayName = "ResortPage", 
        GUID = "c4763d99-835b-4d8d-8109-8e18f5238288",
        Description = "Resort Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class ResortPage : SitePageData
    {
        [Display(Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageA { get; set; }

        [Display(Order = 150)]
        public virtual XhtmlString MainBodyContent { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 200)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

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