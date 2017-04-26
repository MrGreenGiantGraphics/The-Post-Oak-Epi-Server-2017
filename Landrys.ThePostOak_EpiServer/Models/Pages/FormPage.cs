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
        DisplayName = "Form-Page Template", 
        GUID = "22583151-d71c-4a9f-b05a-400c7df8022f",
        Description = "Basic Template for Content")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class FormPage : SitePageData
    {
        [Display(Order = 10)]
        public virtual XhtmlString ContentHolderTop { get; set; }

        [Display(Order = 20)]
        public virtual XhtmlString ContentHolderMain { get; set; }

        [Display(Order = 30)]
        [CultureSpecific]
        public virtual ContentArea ContentAreaHolder { get; set; }

        [Display(Order = 40)]
        [CultureSpecific]
        public virtual ContentArea ContentAreaPlacer { get; set; }

        [CultureSpecific]
        public virtual ContentArea ContentAreaPlacer1 { get; set; }

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