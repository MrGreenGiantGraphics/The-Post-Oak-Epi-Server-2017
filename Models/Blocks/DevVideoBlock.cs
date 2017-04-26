using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer.SpecializedProperties;
using EPiServer;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "DevVideoBlock", 
        GUID = "7e0e053e-9575-4ebe-a11f-29ee11ed16e6",
        Description = "Post Oak Video Overlay Block Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class DevVideoBlock : SiteBlockData
    {
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image A",
            Order = 1)]
        public virtual ContentReference ImageA { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string AltA { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image B",
            Order = 1)]
        public virtual ContentReference ImageB { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string AltB { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image C",
            Order = 3)]
        public virtual ContentReference ImageC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string AltC { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "OverLay A",
            Order = 4)]
        public virtual ContentReference OverlayA { get; set; }

        [Display(Name = "Overlay link A",
         Description = "link the url here",
         GroupName = SystemTabNames.Content)]
        [BackingType(typeof(PropertyUrl))]
        public virtual Url LinkUrlA { get; set; }

        [Display(Name = "Overlay Script Option",
        Description = "URL Link Here",
        GroupName = SystemTabNames.Content)]
        [BackingType(typeof(PropertyUrl))]
        public virtual Url LinkUrlHash { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "OverLay B",
            Order = 5)]
        public virtual ContentReference OverlayB { get; set; }

        [Display(Name = "Overlay link B",
             Description = "link the url here",
             GroupName = SystemTabNames.Content)]
        [BackingType(typeof(PropertyUrl))]
        public virtual Url LinkUrlB { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "OverLay C",
            Order = 6)]
        public virtual ContentReference OverlayC { get; set; }

        [Display(Name = "Overlay link C",
             Description = "link the url here",
             GroupName = SystemTabNames.Content)]
        [BackingType(typeof(PropertyUrl))]
        public virtual Url LinkUrlC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Main Text Area",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual XhtmlString TextEdit { get; set; }
    }
}