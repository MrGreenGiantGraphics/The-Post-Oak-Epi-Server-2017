using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "Post Oak Contact Page", 
        GUID = "bf875e01-11aa-4db8-9ce4-6353596c6dc9", 
        Description = "Post Oak - Alloy Contact Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class ContactPage : SitePageData
    {
        [CultureSpecific]
        [Display(
         Name = "Main Body",
         Description = "This will display main body.",
         GroupName = SystemTabNames.Content,
         Order = 125)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "This will display main body.",
            GroupName = SystemTabNames.Content,
            Order = 130)]
        public virtual XhtmlString MainBodyTwo { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Content Area",
            Description = "This will display the main content area.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Order = 180)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageHeader { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        public virtual string Phone { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        [Business.EmailAddress]
        public virtual string Email { get; set; }
    }
}