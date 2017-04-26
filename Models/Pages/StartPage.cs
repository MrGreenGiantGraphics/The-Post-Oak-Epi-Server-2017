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
        DisplayName = "StartPage", 
        GUID = "f9852a00-479f-48e8-a617-b4e767b10279", 
        Description = "Start Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ContentFolder)},
        // Pages we can create under the start page...
        ExcludeOn = new[] { typeof(ContentFolder)})]
    //eath those we can't create additional start pages
    public class StartPage : SitePageData
    {

        [Display(Order = 10)]
        public virtual XhtmlString TextPoCon { get; set; }

        [Display(Order = 15)]
        public virtual XhtmlString TextPoNav { get; set; }

        [Display(Order = 25)]
        public virtual XhtmlString ContentHolder01 { get; set; }

        [Display(Order = 30)]
        public virtual XhtmlString ContentHolder02 { get; set; }

        [Display(Order = 35)]
        public virtual XhtmlString ContentHolder03 { get; set; }

        [Display(Order = 40)]
        public virtual XhtmlString ContentHolder04 { get; set; }

        [CultureSpecific]
        public virtual ContentArea MainContentKind { get; set; }

        [CultureSpecific]
        public virtual ContentArea MainContentDev { get; set; }

        [CultureSpecific]
        public virtual ContentArea lightBoxHolder { get; set; }

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