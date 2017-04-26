using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Landrys.ThePostOak_EpiServer.Models.Blocks;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Layout-Subpage", 
        GUID = "c610d2ef-7965-4170-aad8-cf70b79f1bad",
        Description = "Layout-Subpage Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class LayoutSub : SitePageData
    {
        [CultureSpecific]
        public virtual ContentArea ContentHolder { get; set; }

        [CultureSpecific]
        public virtual ContentArea ContentSlider { get; set; }

        [Display(Order = 205)]
        public virtual XhtmlString ContentHolder01 { get; set; }

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