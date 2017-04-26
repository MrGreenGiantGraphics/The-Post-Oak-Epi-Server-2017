using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "LightBox-Block", 
        GUID = "0f6458dd-fd1f-4ab8-b247-5f8cc3350ccf", 
        Description = "Home Light Box")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class lightboxBlock : BlockData
    {

        //Section One of Five
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-One Large",
                 Order = 1)]
        public virtual ContentReference ImageALarge { get; set; }

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
        [Display(Name = "Image-One Small",
         Order = 2)]
        public virtual ContentReference ImageASmall { get; set; }

        //Section Two of Five
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Two Large",
         Order = 3)]
        public virtual ContentReference ImageBLarge { get; set; }

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
        [Display(Name = "Image-Two Small",
         Order = 4)]
        public virtual ContentReference ImageBSmall { get; set; }

        //Section Three of Five
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Three Large",
         Order = 5)]
        public virtual ContentReference ImageCLarge { get; set; }

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
        [Display(Name = "Image-Three Small",
         Order = 6)]
        public virtual ContentReference ImageCSmall { get; set; }

        //Section Four of Five
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Four Large",
         Order = 7)]
        public virtual ContentReference ImageDLarge { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string AltD { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Four Small",
         Order = 8)]
        public virtual ContentReference ImageDSmall { get; set; }


        //Section Four of Five
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Five Large",
         Order = 9)]
        public virtual ContentReference ImageELarge { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual string AltE { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image-Five Small",
         Order = 10)]
        public virtual ContentReference ImageESmall { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Header Text Area",
            GroupName = SystemTabNames.Content,
            Order = 11)]
        public virtual XhtmlString HeadContent { get; set; }
    }
}