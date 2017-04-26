using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using Landrys.ThePostOak_EpiServer.Models.Blocks;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "LayoutPage", 
        GUID = "a04604e4-e6bf-4ff7-a93a-68da4e989dd2", 
        Description = "Test Template Responsive Design")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class LayoutPage : SitePageData
    {
        [Display(Order = 10)]
        public virtual XhtmlString TextPoCon { get; set; }

        [Display(Order = 20)]
        [CultureSpecific]
        public virtual ContentArea lightboxholder { get; set; }

        [Display(Order = 30)]
        [CultureSpecific]
        public virtual ContentArea MainContentKind { get; set; }

        [Display(Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageHolder { get; set; }

        [Display(Order = 50)]
        public virtual XhtmlString MainBodyContent { get; set; }

        [Display(Order = 60)]
        public virtual XhtmlString MainContentPost { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 70)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Order = 80)]
        [CultureSpecific]
        public virtual ContentArea MainContentDev { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 90)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 100)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }
        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }
    }
}