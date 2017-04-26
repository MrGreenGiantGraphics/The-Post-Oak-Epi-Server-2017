using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        DisplayName = "ContactBlock-Template", 
        GUID = "c47cbe5c-178f-4507-9563-1a2bb900184c", 
        Description = "Post Oak Contact Block Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class ContactBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        /// <summary>
        /// Gets or sets the contact page from which contact information should be retrieved
        /// </summary>
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(Global.SiteUIHints.Contact)]
        public virtual PageReference ContactPageLink { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [CultureSpecific]
        public virtual string LinkText { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [CultureSpecific]
        public virtual Url LinkUrl { get; set; }
    }
}