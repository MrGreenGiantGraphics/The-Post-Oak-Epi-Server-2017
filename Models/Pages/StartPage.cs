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

        [Display(Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImagePoTop { get; set; }

        [Display(Order = 25)]
        public virtual XhtmlString ContentHolder01 { get; set; }

        [Display(Order = 30)]
        public virtual XhtmlString ContentHolder02 { get; set; }

        [Display(Order = 35)]
        public virtual XhtmlString ContentHolder03 { get; set; }

        [Display(Order = 40)]
        public virtual XhtmlString ContentHolder04 { get; set; }

        [Display(Order = 45)]
        public virtual XhtmlString ContentHolder05 { get; set; }

        [Display(Order = 46)]
        public virtual XhtmlString ContentHolder06 { get; set; }

        [Display(Order = 47)]
        public virtual XhtmlString ContentHolder07 { get; set; }

        [Display(Order = 48)]
        public virtual XhtmlString ContentHolder08 { get; set; }

        [Display(Order = 50)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom01 { get; set; }

        [Display(Order = 55)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom02 { get; set; }

        [Display(Order = 60)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom03 { get; set; }

        [Display(Order = 65)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom04 { get; set; }

        [Display(Order = 70)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom05 { get; set; }

        [Display(Order = 75)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBottom06 { get; set; }

        [Display(Order = 150)]
        public virtual XhtmlString MainBodyContent { get; set; }

        [Display(GroupName = SystemTabNames.Content, 
                 Order = 200)]
        [CultureSpecific]
        public virtual ContentArea MainContentPost { get; set; }

        [CultureSpecific]
        public virtual ContentArea ImageAreaHolder01 { get; set; }

        [CultureSpecific]
        public virtual ContentArea ImageAreaHolder02 { get; set; }

        [CultureSpecific]
        public virtual ContentArea MainContentKind { get; set; }

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