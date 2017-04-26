using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Content-Image-Block",
        GUID = "ffc8c3aa-2560-4137-92ae-b1e032c80d34",
        Description = "Use this block for mid Image")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class ContentImageBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Block ImageUrl",
            Order = 1)]
        public virtual Url ImageUrl { get; set; }

        [Display(Name = "link",
         Description = "Image link",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        public virtual PageReference Link { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image Block A",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentReference ImageA { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(
        Name = "Image Block B",
        GroupName = SystemTabNames.Content,
        Order = 4)]
        public virtual ContentReference ImageB { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(
         Name = "Image Block C",
         GroupName = SystemTabNames.Content,
         Order = 5)]
        public virtual ContentReference ImageC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(
         Name = "Image Block D",
         GroupName = SystemTabNames.Content,
         Order = 6)]
        public virtual ContentReference ImageD { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
         Name = "ADA Alternative Text A",
         GroupName = SystemTabNames.Content,
         Order = 7)]
        [UIHint(UIHint.Textarea)]
        public virtual string AlternativeTextA { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
         Name = "ADA Alternative Text B",
         GroupName = SystemTabNames.Content,
         Order = 8)]
        [UIHint(UIHint.Textarea)]
        public virtual string AlternativeTextB { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
         Name = "ADA Alternative Text C",
         GroupName = SystemTabNames.Content,
         Order = 9)]
        [UIHint(UIHint.Textarea)]
        public virtual string AlternativeTextC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
        Name = "ADA Alternative Text D",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        [UIHint(UIHint.Textarea)]
        public virtual string AlternativeTextD { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
         Name = "Main Text Area A",
         GroupName = SystemTabNames.Content,
         Order = 11)]
        public virtual XhtmlString TextEditA { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
         Name = "Main Text Area B",
         GroupName = SystemTabNames.Content,
         Order = 12)]
        public virtual XhtmlString TextEditB { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
         Name = "Main Text Area C",
         GroupName = SystemTabNames.Content,
         Order = 13)]
        public virtual XhtmlString TextEditC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
        Name = "Main Text Area D",
        GroupName = SystemTabNames.Content,
        Order = 14)]
        public virtual XhtmlString TextEditD { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 15)]
        [CultureSpecific]
        [Required]
        public virtual string ButtonTextA { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 16)]
        [CultureSpecific]
        [Required]
        public virtual string ButtonTextB { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 17)]
        [CultureSpecific]
        [Required]
        public virtual string ButtonTextC { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 18)]
        [CultureSpecific]
        [Required]
        public virtual string ButtonTextD { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 19)]
        [CultureSpecific]
        [Required]
        public virtual Url ButtonLinkA { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 20)]
        [CultureSpecific]
        [Required]
        public virtual Url ButtonLinkB { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 21)]
        [CultureSpecific]
        [Required]
        public virtual Url ButtonLinkC { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 22)]
        [CultureSpecific]
        [Required]
        public virtual Url ButtonLinkD { get; set; }

        [Display(
         GroupName = SystemTabNames.Content,
         Order = 23)]
        [CultureSpecific]
        [Required]
        public virtual Url ImageALink { get; set; }

        [Display(
        GroupName = SystemTabNames.Content,
        Order = 24)]
        [CultureSpecific]
        [Required]
        public virtual Url ImageBLink { get; set; }

        [Display(
          GroupName = SystemTabNames.Content,
          Order = 25)]
        [CultureSpecific]
        [Required]
        public virtual Url ImageCLink { get; set; }

        [Display(
        GroupName = SystemTabNames.Content,
        Order = 26)]
        [CultureSpecific]
        [Required]
        public virtual Url ImageDLink { get; set; }

    }
}